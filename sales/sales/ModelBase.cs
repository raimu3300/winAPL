using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sales
{
    class ModelBase: IDataErrorInfo
    {
        private readonly Dictionary<string, string>
            _errors = new Dictionary<string, string>();

        public virtual string Error
        {
            get
            {
                return
                    _errors.Count > 0 ?
                    "項目の値が不明です" :
                    "";
            }
        }

        public string this[string propertyName]
        {
            get
            {
                return
                    _errors.ContainsKey(propertyName) ?
                    _errors[propertyName] :
                    "";
            }
        }

        protected void UpdateErrors(string propertyName, string errorMessage)
        {
            if (string.IsNullOrEmpty(errorMessage))
            {
                _errors.Remove(propertyName);
            }
            else
            {
                _errors[propertyName] = errorMessage;
            }
        }
    }
}
