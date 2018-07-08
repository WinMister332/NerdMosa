// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

namespace Mosa.Compiler.Framework.IR
{
	/// <summary>
	/// LoadParamZeroExtend8x64
	/// </summary>
	/// <seealso cref="Mosa.Compiler.Framework.IR.BaseIRInstruction" />
	public sealed class LoadParamZeroExtend8x64 : BaseIRInstruction
	{
		public override int ID { get { return 87; } }

		public LoadParamZeroExtend8x64()
			: base(1, 1)
		{
		}

		public override bool IsMemoryRead { get { return true; } }
	}
}
