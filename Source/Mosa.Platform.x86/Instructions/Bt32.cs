// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

using Mosa.Compiler.Framework;

namespace Mosa.Platform.x86.Instructions
{
	/// <summary>
	/// Bt32
	/// </summary>
	/// <seealso cref="Mosa.Platform.x86.X86Instruction" />
	public sealed class Bt32 : X86Instruction
	{
		public override int ID { get { return 196; } }

		internal Bt32()
			: base(1, 2)
		{
		}

		public static readonly LegacyOpCode LegacyOpcode = new LegacyOpCode(new byte[] { 0x0F, 0xA3 });

		public override bool HasUnspecifiedSideEffect { get { return true; } }

		public override bool IsCarryFlagModified { get { return true; } }

		public override bool IsSignFlagUnchanged { get { return true; } }

		public override bool IsSignFlagUndefined { get { return true; } }

		public override bool IsOverflowFlagUnchanged { get { return true; } }

		public override bool IsOverflowFlagUndefined { get { return true; } }

		public override bool IsParityFlagUnchanged { get { return true; } }

		public override bool IsParityFlagUndefined { get { return true; } }

		internal override void EmitLegacy(InstructionNode node, X86CodeEmitter emitter)
		{
			System.Diagnostics.Debug.Assert(node.ResultCount == 1);
			System.Diagnostics.Debug.Assert(node.OperandCount == 2);

			emitter.Emit(LegacyOpcode, node.Result, node.Operand2);
		}
	}
}
