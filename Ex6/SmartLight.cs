using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    internal class SmartLight
    {
        public event Action OnStateChanged;
        private Boolean IsOn;
        private int Brightness;
        public void Toggle(Boolean flag,int strang)
        {
            IsOn = flag;
            Brightness = strang;
            OnStateChanged?.Invoke();
        }
    }
}
