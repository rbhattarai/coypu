﻿namespace Coypu
{
	public abstract class Node
	{
		public string Id { get; protected set; }
		public string Text { get; protected set; }
		public string Value { get; protected set; }
		public object UnderlyingNode { get; protected set; }
		public abstract void Update();
	}
}