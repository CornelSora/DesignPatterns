using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    class CustomersBase
    {
        private DataObject _dataObject;
        protected string group;

        public CustomersBase(string group)
        {
            this.group = group;
        }

        public DataObject Data
        {
            get { return _dataObject; }
            set { _dataObject = value; }
        }

        public virtual void Next()
        {
            _dataObject.NextRecord();
        }

        public virtual void Prior()
        {
            _dataObject.PriorRecord();
        }

        public virtual void Add(string name)
        {
            _dataObject.AddRecord(name);
        }

        public virtual void Delete(string name)
        {
            _dataObject.DeleteRecord(name);
        }

        public virtual void Show()
        {
            _dataObject.ShowRecord();
        }

        public virtual void ShowAll()
        {
            Console.WriteLine("The group: " + group);
            _dataObject.ShowAllRecords();
        }
    }
}
