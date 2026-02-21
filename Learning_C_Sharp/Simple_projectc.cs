using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Threading.Tasks;

namespace IssueTrackerPro
{
    // 1. CUSTOM EXCEPTION
    public class IssueNotFoundException : Exception
    {
        public IssueNotFoundException(string message) : base(message) { }
    }

    // 2. ATTRIBUTE
    [AttributeUsage(AttributeTargets.Property)]
    public class AuditableAttribute : Attribute
                {
    }

    // 3. DTO (replaced C# 'record' with a class for C# 7.3)
    public class UserDto
    {
        public int Id { get; }
        public string Name { get; }

        public UserDto(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    public enum Status { Open, InProgress, Closed }

    // 4. ABSTRACT CLASS
    public abstract class WorkItem
    {
        public int Id { get; set; }

        [Auditable]
        public string Title { get; set; } = string.Empty;

        private Status _status;

        public Status Status
        {
            get => _status;
            set
            {
                if (_status != value)
                {
                    _status = value;
                    OnStatusChanged?.Invoke(this, new StatusChangedEventArgs(Id, _status));
                }
            }
        }

        // Nullable reference types aren't available in C# 7.3; leave as a normal reference
        public UserDto Assignee { get; set; }

        public event EventHandler<StatusChangedEventArgs> OnStatusChanged;

        protected WorkItem(int id, string title)
        {
            Id = id;
            Title = title;
            Status = Status.Open;
        }

        public abstract string GetPriorityLevel();
    }

    public class StatusChangedEventArgs : EventArgs
    {
        public int IssueId { get; }
        public Status NewStatus { get; }

        public StatusChangedEventArgs(int id, Status status)
        {
            IssueId = id;
            NewStatus = status;
        }
    }

    // 5. INHERITANCE
    public class Bug : WorkItem
    {
        public string Severity { get; set; }

        public Bug(int id, string title, string severity)
            : base(id, title)
        {
            Severity = severity;
        }

        public override string GetPriorityLevel()
            => Severity == "Critical" ? "High" : "Normal";
    }

    public class FeatureRequest : WorkItem
    {
        public int Votes { get; set; }

        public FeatureRequest(int id, string title, int votes)
            : base(id, title)
        {
            Votes = votes;
        }

        public override string GetPriorityLevel()
            => Votes > 100 ? "High" : "Low";
    }

    // 6. GENERIC REPOSITORY
    public interface IRepository<T> where T : class
    {
        void Add(T item);
        T GetById(int id);
        IEnumerable<T> GetAll();
    }

    public class Repository<T> : IRepository<T> where T : WorkItem
    {
        private readonly Dictionary<int, T> _storage = new Dictionary<int, T>();

        public void Add(T item) => _storage[item.Id] = item;

        public T GetById(int id)
        {
            if (!_storage.TryGetValue(id, out T item))
                throw new IssueNotFoundException($"Item with ID {id} was not found.");

            return item;
        }

        public IEnumerable<T> GetAll() => _storage.Values;
    }

    // 7. EXTENSION METHOD
    public static class StringExtensions
    {
        public static string ToTitleCase(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return str;

            return char.ToUpper(str[0]) + str.Substring(1).ToLower();
        }
    }

    class Simple_projectc
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("--- Starting IssueTracker Pro ---\n");

            var repo = new Repository<WorkItem>();
            var currentUser = new UserDto(1, "Alice");

            var bug1 = new Bug(1, "database timeout error".ToTitleCase(), "Critical")
            {
                Assignee = currentUser
            };

            var feature1 = new FeatureRequest(2, "Add dark mode", 150)
            {
                Assignee = currentUser
            };

            bug1.OnStatusChanged += (sender, e) =>
                Console.WriteLine($"[EVENT] Issue {e.IssueId} changed status to {e.NewStatus}");

            repo.Add(bug1);
            repo.Add(feature1);

            bug1.Status = Status.InProgress;

            Console.WriteLine("\n--- High Priority Items (LINQ) ---");

            var highPriorityItems = repo.GetAll()
                                        .Where(item => item.GetPriorityLevel() == "High")
                                        .OrderBy(item => item.Id);

            foreach (var item in highPriorityItems)
            {
                string description;
                if (item is Bug b)
                {
                    description = $"Bug: {b.Title} (Severity: {b.Severity})";
                }
                else if (item is FeatureRequest f)
                {
                    description = $"Feature: {f.Title} (Votes: {f.Votes})";
                }
                else
                {
                    description = "Unknown Work Item";
                }

                Console.WriteLine(description);
            }

            Console.WriteLine("\n--- Auditable Properties (Reflection) ---");

            PropertyInfo[] props = typeof(Bug).GetProperties()
                .Where(prop => Attribute.IsDefined(prop, typeof(AuditableAttribute)))
                .ToArray();

            foreach (var prop in props)
            {
                Console.WriteLine($"Property '{prop.Name}' is marked for auditing.");
            }

            Console.WriteLine("\n--- Testing Error Handling ---");

            try
            {
                repo.GetById(99);
            }
            catch (IssueNotFoundException ex)
            {
                Console.WriteLine($"Caught Exception: {ex.Message}");
            }

            Console.WriteLine("\n--- Saving Data (Async) ---");

            string json = JsonSerializer.Serialize(
                repo.GetAll().ToList(),
                new JsonSerializerOptions { WriteIndented = true });

            await Task.Delay(500);
            Console.WriteLine("Data saved successfully:\n" + json);

            Console.WriteLine("\n--- Starting Background Maintenance Task ---");

            _ = Task.Run(async () =>
            {
                await Task.Delay(1000);
                Console.WriteLine("[BACKGROUND TASK] Cleaned up old system logs.");
            });

            await Task.Delay(1500);

            Console.WriteLine("\nApplication finished running.");
        }
    }
}