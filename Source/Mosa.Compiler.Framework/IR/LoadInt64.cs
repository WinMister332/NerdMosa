// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

namespace Mosa.Compiler.Framework.IR
{
	/// <summary>
	/// LoadInt64
	/// </summary>
	/// <seealso cref="Mosa.Compiler.Framework.IR.BaseIRInstruction" />
	public sealed class LoadInt64 : BaseIRInstruction
	{
		public override int ID { get { return 67; } }

		public LoadInt64()
			: base(2, 1)
		{
		}

		public override bool IsMemoryRead { get { return true; } }
	}
}
