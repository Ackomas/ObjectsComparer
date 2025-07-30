using System.Collections.Generic;
using System.Reflection;

namespace ObjectsComparer
{
    /// <summary>
    /// Defines methods to compare complex objects of particular type.
    /// </summary>
    public interface IComparer<in T>: IBaseComparer
    {
        /// <summary>
        /// Compares two objects of the specified type.
        /// </summary>
        /// <param name="obj1">The first object to compare.</param>
        /// <param name="obj2">The second object to compare.</param>
        /// <param name="differences">The collection of differences found during the comparison.</param>
        /// <param name="memberInfo">The metadata information of the member being compared.</param>
        /// <returns>True if the objects are equal; otherwise, false.</returns>
        bool Compare(T obj1, T obj2, out IEnumerable<Difference> differences, MemberInfo memberInfo);

        /// <summary>
        /// Compares objects.
        /// </summary>
        /// <param name="obj1">Object 1.</param>
        /// <param name="obj2">Object 2.</param>
        /// <returns>True if objects are equal, otherwise false.</returns>
        bool Compare(T obj1, T obj2);

        /// <summary>
        /// Calculates a list of differences between two objects of the specified type.
        /// </summary>
        /// <param name="obj1">The first object to compare.</param>
        /// <param name="obj2">The second object to compare.</param>
        /// <param name="memberInfo">The metadata information of the member being compared.</param>
        /// <returns>A collection of differences found between the two objects.</returns>
        IEnumerable<Difference> CalculateDifferences(T obj1, T obj2, MemberInfo memberInfo);
    }
}