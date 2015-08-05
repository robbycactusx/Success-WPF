
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuccessLib.Framework
{
    public class ValidatableBase : BindableBase, INotifyDataErrorInfo
    {
        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged = delegate { };

        protected override void SetPropertyChanged<T>(ref T field, T value, string propertyName)
        {
            base.SetPropertyChanged<T>(ref field, value, propertyName);
            ValidateProperty<T>(propertyName, value);
        }

        private Dictionary<string,List<string>> _errors = new Dictionary<string,List<string>>();
        public System.Collections.IEnumerable GetErrors(string propertyName)
        {
            if (_errors.ContainsKey(propertyName))
                return _errors[propertyName];

            return null;
        }

        public bool HasErrors
        {
            get {
                return _errors.Count > 0;
            }
        }

        
        private void ValidateProperty<T>(string propertyName, T value)
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(this);
            context.MemberName = propertyName;
            Validator.TryValidateProperty(value, context, results);

            if(results.Any())
            {
                _errors[propertyName] = results.Select(p => p.ErrorMessage).ToList<string>();
            }
            else
            {
                _errors.Remove(propertyName);
            }
            ErrorsChanged(this, new DataErrorsChangedEventArgs(propertyName));
        }
    }
}
