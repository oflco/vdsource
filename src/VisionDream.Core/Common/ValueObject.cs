// Copyright (c) VisionDream Authors.
// Licensed under the MIT License.

namespace VisionDream.Core.Common
{
    /// <summary>
    /// Value object abstract base type.
    /// </summary>
    /// <remarks>
    /// <para>
    /// The base <see cref="ValueObject"/> <c><see langword="abstract"/></c>
    /// class is inherited by the derived classes.
    /// </para>
    /// </remarks>
    public abstract class ValueObject
    {
        /// <summary>
        /// Get atomic values collection enumerator.
        /// </summary>
        /// <param name="object">
        /// <see cref="object"/> type to enumerate. <see cref="ValueObject"/>.
        /// </param>
        /// <returns>
        /// An enumerator that can be used to iterate through the collection.
        /// </returns>
        /// <remarks>
        /// <para>
        /// <see cref="GetAtomicValues"/> collection enumerator iterates
        /// through the <see cref="object"/> enumerable collection.
        /// </para>
        /// </remarks>
        protected abstract IEnumerable<object?> GetAtomicValues();

        protected static bool EqualOperator(ValueObject left, ValueObject right)
        {
            if (left is null ^ right is null)
            {
                return false;
            }

            return left?.Equals(right) != false;
        }

        protected static bool NotEqualOperator(ValueObject left, ValueObject right)
        {
            return !(EqualOperator(left, right));
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || obj.GetType() != GetType())
            {
                return false;
            }

            var other = (ValueObject)obj;
            var thisValues = GetAtomicValues().GetEnumerator();
            var otherValues = other.GetAtomicValues().GetEnumerator();

            while (thisValues.MoveNext() && otherValues.MoveNext())
            {
                if (thisValues.Current is null ^ otherValues.Current is null)
                {
                    return false;
                }

                if (thisValues.Current != null &&
                    !thisValues.Current.Equals(otherValues.Current))
                {
                    return false;
                }
            }

            return !thisValues.MoveNext() && !otherValues.MoveNext();
        }

        public override int GetHashCode()
        {
            return GetAtomicValues()
                .Select(x => x != null ? x.GetHashCode() : 0)
                .Aggregate((x, y) => x ^ y);
        }
    }
}
