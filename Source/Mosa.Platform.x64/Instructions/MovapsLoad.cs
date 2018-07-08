// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

using Mosa.Compiler.Framework;

namespace Mosa.Platform.x64.Instructions
{
	/// <summary>
	/// MovapsLoad
	/// </summary>
	/// <seealso cref="Mosa.Platform.x64.X64Instruction" />
	public sealed class MovapsLoad : X64Instruction
	{
		public override int ID { get { return 457; } }

		internal MovapsLoad()
			: base(1, 2)
		{
		}

		public override bool IsMemoryRead { get { return true; } }

		public override bool ThreeTwoAddressConversion { get { return true; } }

		public override void Emit(InstructionNode node, BaseCodeEmitter emitter)
		{
			System.Diagnostics.Debug.Assert(node.ResultCount == DefaultResultCount);
			System.Diagnostics.Debug.Assert(node.OperandCount == DefaultOperandCount);

			//StaticEmitters.EmitMovapsLoad(node, emitter);
		}
	}
}
