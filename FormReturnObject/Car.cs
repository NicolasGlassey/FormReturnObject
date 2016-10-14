using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormReturnObject
{
    public class Car
    {
        #region private attributes
        private string _brand;
        private string _model;
        #endregion private attributes

        #region constructors
        public Car (string brand, string model)
        {
            _brand = brand;
            _model = model;
        }
        #endregion constructors

        #region accessors and mutators
        public string brand
        {
            get
            {
                return this._brand;
            }
            set
            {
                this._brand = value;
            }
        }

        public string model
        {
            get
            {
                return this._model;
            }
            set
            {
                this._model = value;
            }
        }
        #endregion accessors and mutators

    }
}
