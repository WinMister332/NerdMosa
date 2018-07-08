// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

namespace Mosa.Compiler.Framework.IR
{
	/// <summary>
	/// Flow
	/// </summary>
	/// <seealso cref="Mosa.Compiler.Framework.IR.BaseIRInstruction" />
	public sealed class Flow : BaseIRInstruction
	{
		public override int ID { get { return 48; } }

		public Flow()
			: base(0, 0)
		{
		}

		public override bool IgnoreDuringCodeGeneration { get { return true; } }
	}
}
