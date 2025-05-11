using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C7
{
    internal class WifiAdapter : WiFi
    {
        private readonly WiFi2 _wifi2;
        protected string _network;

        public WifiAdapter(WiFi2 wifi2, string network) : base(network, "random")
        {
            this._wifi2 = wifi2;
            this._network = network;
        }

        public override bool IsCurrentlyOn
        {
            get { return _wifi2.IsCurrentlyOn; }
            set { _wifi2.IsCurrentlyOn = value;}
        }

        public override void Login(string pwd)
        {
            _wifi2.Login(_network, pwd);
        }
    }
}
