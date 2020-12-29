using System.Collections;
using System.Collections.Generic;

namespace Structures
{
    public class HouseOfSantaClaus : IEnumerable<Child>
    {
        public Queue<Child> children;

        public HouseOfSantaClaus()
        {
            children = new Queue<Child>();
        }

        public void AddChild(Child c)
        {
            children.Add(c);
        }

        public void RemoveChild(int id)
        {
            children.Remove(id);
        }

        public bool IsEmptyDepartment()
        {
            return children.IsEmptyList();
        }

        public IEnumerator<Child> GetEnumerator()
        {
            return children.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public void Show()
        {
            foreach (var item in children)
            {
                item.Info();
            }
        }
    }
}