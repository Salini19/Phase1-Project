using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PlayerandTeam
{
    public class Player
    {
		private int _id;

		public int PlayerID
		{
			get { return _id; }
			set { _id = value; }
		}

		private string _name;

		public string PlayerName
		{
			get { return _name; }
			set { _name = value; }
		}

		private int _age;

		public int Age
		{
			get { return _age; }
			set { _age = value; }
		}
		


	}
}
