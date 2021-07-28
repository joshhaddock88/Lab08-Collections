using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08Collections.interfaces
{
  public interface IBag<T> : IEnumerable<T>
  {
    /// Add an item to the bag. <c>null</c> items are ignored.
    void Pack(T item);

    /// Remove the item from the bag at the given index.
    /// <returns>The item that was removed.</returns>
    T Unpack(int index);
  }
}
