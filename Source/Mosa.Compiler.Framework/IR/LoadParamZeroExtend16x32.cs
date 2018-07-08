// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

namespace Mosa.Compiler.Framework.IR
{
	/// <summary>
	/// LoadParamZeroExtend16x32
	/// </summary>
	/// <seealso cref="Mosa.Compiler.Framework.IR.BaseIRInstruction" />
	public sealed class LoadParamZeroExtend16x32 : BaseIRInstruction
	{
		public override int ID { get { return 86; } }

		public LoadParamZeroExtend16x32()
			: base(1, 1)
		{
		}

		public override bool IsMemoryRead { get { return true; } }
	}
}
