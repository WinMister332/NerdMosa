// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

using Mosa.Compiler.Framework;

namespace Mosa.Platform.x64.Instructions
{
	/// <summary>
	/// SetByteIfParity
	/// </summary>
	/// <seealso cref="Mosa.Platform.x64.X64Instruction" />
	public sealed class SetByteIfParity : X64Instruction
	{
		public override int ID { get { return 581; } }

		internal SetByteIfParity()
			: base(1, 0)
		{
		}

		public override string AlternativeName { get { return "SetP"; } }

		public static readonly LegacyOpCode LegacyOpcode = new LegacyOpCode(new byte[] { 0x0F, 0x9A });

		public override bool IsParityFlagUsed { get { return true; } }

		public override BaseInstruction GetOpposite()
		{
			return X64.SetByteIfNoParity;
		}

		internal override void EmitLegacy(InstructionNode node, X64CodeEmitter emitter)
		{
			System.Diagnostics.Debug.Assert(node.ResultCount == 1);
			System.Diagnostics.Debug.Assert(node.OperandCount == 0);

			emitter.Emit(LegacyOpcode, node.Result);
		}
	}
}
