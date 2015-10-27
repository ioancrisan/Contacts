using System.Collections.Generic;
using ContactLibrary;

namespace Contacts
{
    public interface IRepository
    {
        bool Add(Contact c);
        bool Update(Contact oldContact, Contact newContact);
        List<Contact> GetAll();
        bool Delete(Contact c);
    }
}