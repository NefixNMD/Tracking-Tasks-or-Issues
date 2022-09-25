using tracking.Models;

namespace tracking.Extensions
{
    public static class PriorityExtensions
    {
        static readonly Dictionary<Priority, string> _priorityCssClasses = new()
        {
            [Priority.Low] = "badge bg-success",
            [Priority.High] = "badge bg-danger",
            [Priority.Medium] = "badge bg-warning text-dark"
        };

        public static string ToCssClass(this Priority priority) => _priorityCssClasses[priority];
    }
}
