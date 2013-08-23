namespace System {
#pragma warning disable 436
	[AttributeUsage (AttributeTargets.All, AllowMultiple=true)]
	internal class MonoTODOAttribute : Attribute {

		string comment;
		
		public MonoTODOAttribute ()
		{
		}

		public MonoTODOAttribute (string comment)
		{
			this.comment = comment;
		}

		public string Comment {
			get { return comment; }
		}
	}
#pragma warning restore 436	
}
