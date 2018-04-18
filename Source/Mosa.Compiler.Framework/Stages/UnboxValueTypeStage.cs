﻿// Copyright (c) MOSA Project. Licensed under the New BSD License.

using Mosa.Compiler.Framework.IR;

namespace Mosa.Compiler.Framework.Stages
{
	/// <summary>
	/// Unboxes value types when we are virtually calling a method on a boxed value type.
	/// </summary>
	public class UnboxValueTypeStage : BaseMethodCompilerStage
	{
		private bool triggered = false;

		protected override void Run()
		{
			triggered = false;

			// The method declaring type must be a valuetype
			if (!MethodCompiler.Type.IsValueType)
				return;

			// If the method is static, non-virtual or is a constructor then don't process
			if (MethodCompiler.Method.IsStatic || !MethodCompiler.Method.IsVirtual || MethodCompiler.Method.Name.Equals(".ctor"))
				return;

			// If the method does not belong to an interface then don't process
			if (!(IsInterfaceMethod() || OverridesMethod()))
				return;

			// If the method is empty then don't process
			if (BasicBlocks.PrologueBlock.NextBlocks.Count == 0 || BasicBlocks.PrologueBlock.NextBlocks[0] == BasicBlocks.EpilogueBlock)
				return;

			triggered = true;

			// Get the this pointer
			var thisPtr = MethodCompiler.Parameters[0];

			//todo: move this to the end of prologue
			var context = new Context(BasicBlocks.PrologueBlock.NextBlocks[0].First);

			// Now push the this pointer by two native pointer sizes
			var v1 = AllocateVirtualRegister(TypeSystem.BuiltIn.TypedRef);

			context.AppendInstruction(Select(IRInstruction.LoadInt32, IRInstruction.LoadInt64), v1, StackFrame, thisPtr);
			context.AppendInstruction(Select(IRInstruction.AddSigned32, IRInstruction.AddSigned64), v1, v1, CreateConstant(NativePointerSize * 2));
			context.AppendInstruction(Select(IRInstruction.StoreInt32, IRInstruction.StoreInt64), null, StackFrame, thisPtr, v1);
		}

		protected override void Finish()
		{
			base.Finish();

			UpdateCounter("UnboxValueTypeStage.Triggered", triggered ? 1 : 0);
		}

		private bool IsInterfaceMethod()
		{
			foreach (var iface in MethodCompiler.Type.Interfaces)
			{
				foreach (var method in TypeLayout.GetInterfaceTable(MethodCompiler.Type, iface))
				{
					if (method == MethodCompiler.Method)
						return true;
				}
			}

			return false;
		}

		private bool OverridesMethod()
		{
			if (MethodCompiler.Method.Overrides == null)
				return false;
			if (MethodCompiler.Type.BaseType.Name.Equals("ValueType"))
				return true;
			if (MethodCompiler.Type.BaseType.Name.Equals("Object"))
				return true;
			if (MethodCompiler.Type.BaseType.Name.Equals("Enum"))
				return true;
			return false;
		}
	}
}
