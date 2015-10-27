using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using Contacts;

namespace ContactLibrary
{
    public class RepositoryXml : IRepository
    {
        public RepositoryXml()
        {
            PathName = Path.Combine(DirectoryName, FileName);
            OpenXmlFile();
        }

        public string FileName = "AddressBook.xml";
        public string DirectoryName = "C:\\Contacts";
        public string PathName;
        private static XDocument _doc;
        public bool Add(Contact c)
        {
            if (Contains(c)) return false;
            var contact =
                new XElement("Contact",
                    new XElement("FirstName", c.FirstName),
                    new XElement("LastName", c.LastName),
                    new XElement("PhoneNumber", c.PhoneNumber)
            );
            _doc.Element("AddressBook").Add(contact);
            _doc.Save(PathName);
            return true;
        }

        public bool Update(Contact oldContact, Contact newContact)
        {
            if (!Contains(oldContact) || Contains(newContact) || !Delete(oldContact)) return false;
            if (Add(newContact)) return true;
            Add(oldContact);
            return false;
        }

        public List<Contact> GetAll()
        {
            var contacts =
                from contact in _doc.Descendants("Contact")
                select new Contact(contact.Element("FirstName").Value, contact.Element("LastName").Value,
                        contact.Element("PhoneNumber").Value);
            return contacts.ToList();
        }

        public bool Delete(Contact c)
        {
            if (!Contains(c)) return false;
            _doc.Descendants("Contact").Where(xe =>
                {
                    var xElement = xe.Element("PhoneNumber");
                    return xElement != null && xElement.Value == c.PhoneNumber;
                }).Remove();
            _doc.Save(PathName);
            return true;
        }

        private static bool Contains(Contact c)
        {
            foreach (var contact in (from contact in _doc.Descendants("Contact")
             select new Contact(
                 (string) contact.Element("FirstName"),
                 (string) contact.Element("LastName"),
                 (string) contact.Element("PhoneNumber"))
            ).ToList())
            {
                if (contact.PhoneNumber == c.PhoneNumber) return true;
            }
            return false;
        }

        private void OpenXmlFile()
        {
            if (File.Exists(PathName))
            {
                try
                {
                    _doc = XDocument.Load(PathName);
                }
                catch (XmlException)
                {
                    CompleteXml();
                }
            }
            else if (Directory.Exists(DirectoryName))
            {
                CreateFile();
                CompleteXml();
            }
            else
            {
                Directory.CreateDirectory(DirectoryName);
                CreateFile();
                CompleteXml();
            }
            
        }

        private void CreateFile()
        {
            File.Create(PathName).Close();
        }

        private void CompleteXml()
        {
            _doc = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                 new XElement("AddressBook", "")
            );
            _doc.Save(PathName);
        }
    }
}