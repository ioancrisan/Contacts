using System.Collections.Generic;
using System.Linq;
using Contacts;

namespace ContactLibrary
{
    public class RepositoryMemory : IRepository
    {
        readonly List<Contact> _contactList = new List<Contact>();
        public bool Add(Contact c)
        {
            if (_contactList.Any(item => item.PhoneNumber == c.PhoneNumber))
            {
                return false;
            }
            _contactList.Add(c);
            return true;
        }

        public bool Update(Contact oldContact, Contact newContact)
        {
            if (!_contactList.Contains(oldContact) || _contactList.Contains(newContact) || !Delete(oldContact)) return false;
            if (Add(newContact)) return true;
            Add(oldContact);
            return false;
        }

        public List<Contact> GetAll()
        {
            return _contactList;
        }

        public bool Delete(Contact c)
        {
            foreach (var contact in _contactList.Where(contact => contact.PhoneNumber == c.PhoneNumber))
            {
                _contactList.Remove(contact);
                return true;
            }
            return false;
        }
    }
}