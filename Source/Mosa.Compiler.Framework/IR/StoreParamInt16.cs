// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

namespace Mosa.Compiler.Framework.IR
{
	/// <summary>
	/// StoreParamInt16
	/// </summary>
	/// <seealso cref="Mosa.Compiler.Framework.IR.BaseIRInstruction" />
	public sealed class StoreParamInt16 : BaseIRInstruction
	{
		public override int ID { get { return 154; } }

		public StoreParamInt16()
			: base(2, 0)
		{
		}

		public override bool IsMemoryWrite { get { return true; } }
	}
}
