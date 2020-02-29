// Generated by sprotodump. DO NOT EDIT!
// source: c2s.lua s2c.lua

using System;
using Sproto;
using System.Collections.Generic;

namespace SprotoType { 
	public class ErrorR : SprotoTypeBase {
		private static int max_field_count = 1;
		
		
		private Int64 _code; // tag 0
		public Int64 code {
			get { return _code; }
			set { base.has_field.set_field (0, true); _code = value; }
		}
		public bool HasCode {
			get { return base.has_field.has_field (0); }
		}

		public ErrorR () : base(max_field_count) {}

		public ErrorR (byte[] buffer) : base(max_field_count, buffer) {
			this.decode ();
		}

		protected override void decode () {
			int tag = -1;
			while (-1 != (tag = base.deserialize.read_tag ())) {
				switch (tag) {
				case 0:
					this.code = base.deserialize.read_integer ();
					break;
				default:
					base.deserialize.read_unknow_data ();
					break;
				}
			}
		}

		public override int encode (SprotoStream stream) {
			base.serialize.open (stream);

			if (base.has_field.has_field (0)) {
				base.serialize.write_integer (this.code, 0);
			}

			return base.serialize.close ();
		}
	}


	public class Login : SprotoTypeBase {
		private static int max_field_count = 2;
		
		
		private string _name; // tag 0
		public string name {
			get { return _name; }
			set { base.has_field.set_field (0, true); _name = value; }
		}
		public bool HasName {
			get { return base.has_field.has_field (0); }
		}

		private string _passwd; // tag 1
		public string passwd {
			get { return _passwd; }
			set { base.has_field.set_field (1, true); _passwd = value; }
		}
		public bool HasPasswd {
			get { return base.has_field.has_field (1); }
		}

		public Login () : base(max_field_count) {}

		public Login (byte[] buffer) : base(max_field_count, buffer) {
			this.decode ();
		}

		protected override void decode () {
			int tag = -1;
			while (-1 != (tag = base.deserialize.read_tag ())) {
				switch (tag) {
				case 0:
					this.name = base.deserialize.read_string ();
					break;
				case 1:
					this.passwd = base.deserialize.read_string ();
					break;
				default:
					base.deserialize.read_unknow_data ();
					break;
				}
			}
		}

		public override int encode (SprotoStream stream) {
			base.serialize.open (stream);

			if (base.has_field.has_field (0)) {
				base.serialize.write_string (this.name, 0);
			}

			if (base.has_field.has_field (1)) {
				base.serialize.write_string (this.passwd, 1);
			}

			return base.serialize.close ();
		}
	}


	public class LoginR : SprotoTypeBase {
		private static int max_field_count = 1;
		
		
		private Int64 _pid; // tag 0
		public Int64 pid {
			get { return _pid; }
			set { base.has_field.set_field (0, true); _pid = value; }
		}
		public bool HasPid {
			get { return base.has_field.has_field (0); }
		}

		public LoginR () : base(max_field_count) {}

		public LoginR (byte[] buffer) : base(max_field_count, buffer) {
			this.decode ();
		}

		protected override void decode () {
			int tag = -1;
			while (-1 != (tag = base.deserialize.read_tag ())) {
				switch (tag) {
				case 0:
					this.pid = base.deserialize.read_integer ();
					break;
				default:
					base.deserialize.read_unknow_data ();
					break;
				}
			}
		}

		public override int encode (SprotoStream stream) {
			base.serialize.open (stream);

			if (base.has_field.has_field (0)) {
				base.serialize.write_integer (this.pid, 0);
			}

			return base.serialize.close ();
		}
	}


	public class Match : SprotoTypeBase {
		private static int max_field_count = 1;
		
		
		private Int64 _type; // tag 0
		public Int64 type {
			get { return _type; }
			set { base.has_field.set_field (0, true); _type = value; }
		}
		public bool HasType {
			get { return base.has_field.has_field (0); }
		}

		public Match () : base(max_field_count) {}

		public Match (byte[] buffer) : base(max_field_count, buffer) {
			this.decode ();
		}

		protected override void decode () {
			int tag = -1;
			while (-1 != (tag = base.deserialize.read_tag ())) {
				switch (tag) {
				case 0:
					this.type = base.deserialize.read_integer ();
					break;
				default:
					base.deserialize.read_unknow_data ();
					break;
				}
			}
		}

		public override int encode (SprotoStream stream) {
			base.serialize.open (stream);

			if (base.has_field.has_field (0)) {
				base.serialize.write_integer (this.type, 0);
			}

			return base.serialize.close ();
		}
	}


	public class MatchAckCP : SprotoTypeBase {
		private static int max_field_count = 0;
		
		
		public MatchAckCP () : base(max_field_count) {}

		public MatchAckCP (byte[] buffer) : base(max_field_count, buffer) {
			this.decode ();
		}

		protected override void decode () {
			int tag = -1;
			while (-1 != (tag = base.deserialize.read_tag ())) {
				switch (tag) {
				default:
					base.deserialize.read_unknow_data ();
					break;
				}
			}
		}

		public override int encode (SprotoStream stream) {
			base.serialize.open (stream);

			return base.serialize.close ();
		}
	}


	public class MatchAckP : SprotoTypeBase {
		private static int max_field_count = 0;
		
		
		public MatchAckP () : base(max_field_count) {}

		public MatchAckP (byte[] buffer) : base(max_field_count, buffer) {
			this.decode ();
		}

		protected override void decode () {
			int tag = -1;
			while (-1 != (tag = base.deserialize.read_tag ())) {
				switch (tag) {
				default:
					base.deserialize.read_unknow_data ();
					break;
				}
			}
		}

		public override int encode (SprotoStream stream) {
			base.serialize.open (stream);

			return base.serialize.close ();
		}
	}


	public class MatchP : SprotoTypeBase {
		private static int max_field_count = 2;
		
		
		private List<MatchPlayer> _teamer; // tag 0
		public List<MatchPlayer> teamer {
			get { return _teamer; }
			set { base.has_field.set_field (0, true); _teamer = value; }
		}
		public bool HasTeamer {
			get { return base.has_field.has_field (0); }
		}

		private List<MatchPlayer> _oppos; // tag 1
		public List<MatchPlayer> oppos {
			get { return _oppos; }
			set { base.has_field.set_field (1, true); _oppos = value; }
		}
		public bool HasOppos {
			get { return base.has_field.has_field (1); }
		}

		public MatchP () : base(max_field_count) {}

		public MatchP (byte[] buffer) : base(max_field_count, buffer) {
			this.decode ();
		}

		protected override void decode () {
			int tag = -1;
			while (-1 != (tag = base.deserialize.read_tag ())) {
				switch (tag) {
				case 0:
					this.teamer = base.deserialize.read_obj_list<MatchPlayer> ();
					break;
				case 1:
					this.oppos = base.deserialize.read_obj_list<MatchPlayer> ();
					break;
				default:
					base.deserialize.read_unknow_data ();
					break;
				}
			}
		}

		public override int encode (SprotoStream stream) {
			base.serialize.open (stream);

			if (base.has_field.has_field (0)) {
				base.serialize.write_obj (this.teamer, 0);
			}

			if (base.has_field.has_field (1)) {
				base.serialize.write_obj (this.oppos, 1);
			}

			return base.serialize.close ();
		}
	}


	public class MatchPlayer : SprotoTypeBase {
		private static int max_field_count = 3;
		
		
		private Int64 _pid; // tag 0
		public Int64 pid {
			get { return _pid; }
			set { base.has_field.set_field (0, true); _pid = value; }
		}
		public bool HasPid {
			get { return base.has_field.has_field (0); }
		}

		private string _name; // tag 1
		public string name {
			get { return _name; }
			set { base.has_field.set_field (1, true); _name = value; }
		}
		public bool HasName {
			get { return base.has_field.has_field (1); }
		}

		private string _headIcon; // tag 2
		public string headIcon {
			get { return _headIcon; }
			set { base.has_field.set_field (2, true); _headIcon = value; }
		}
		public bool HasHeadIcon {
			get { return base.has_field.has_field (2); }
		}

		public MatchPlayer () : base(max_field_count) {}

		public MatchPlayer (byte[] buffer) : base(max_field_count, buffer) {
			this.decode ();
		}

		protected override void decode () {
			int tag = -1;
			while (-1 != (tag = base.deserialize.read_tag ())) {
				switch (tag) {
				case 0:
					this.pid = base.deserialize.read_integer ();
					break;
				case 1:
					this.name = base.deserialize.read_string ();
					break;
				case 2:
					this.headIcon = base.deserialize.read_string ();
					break;
				default:
					base.deserialize.read_unknow_data ();
					break;
				}
			}
		}

		public override int encode (SprotoStream stream) {
			base.serialize.open (stream);

			if (base.has_field.has_field (0)) {
				base.serialize.write_integer (this.pid, 0);
			}

			if (base.has_field.has_field (1)) {
				base.serialize.write_string (this.name, 1);
			}

			if (base.has_field.has_field (2)) {
				base.serialize.write_string (this.headIcon, 2);
			}

			return base.serialize.close ();
		}
	}


	public class MatchR : SprotoTypeBase {
		private static int max_field_count = 1;
		
		
		private Int64 _type; // tag 0
		public Int64 type {
			get { return _type; }
			set { base.has_field.set_field (0, true); _type = value; }
		}
		public bool HasType {
			get { return base.has_field.has_field (0); }
		}

		public MatchR () : base(max_field_count) {}

		public MatchR (byte[] buffer) : base(max_field_count, buffer) {
			this.decode ();
		}

		protected override void decode () {
			int tag = -1;
			while (-1 != (tag = base.deserialize.read_tag ())) {
				switch (tag) {
				case 0:
					this.type = base.deserialize.read_integer ();
					break;
				default:
					base.deserialize.read_unknow_data ();
					break;
				}
			}
		}

		public override int encode (SprotoStream stream) {
			base.serialize.open (stream);

			if (base.has_field.has_field (0)) {
				base.serialize.write_integer (this.type, 0);
			}

			return base.serialize.close ();
		}
	}


}

