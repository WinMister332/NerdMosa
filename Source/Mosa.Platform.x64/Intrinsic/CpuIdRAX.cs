﻿// Copyright (c) MOSA Project. Licensed under the New BSD License.

using Mosa.Compiler.Framework;

namespace Mosa.Platform.x64.Intrinsic;

/// <summary>
/// IntrinsicMethods
/// </summary>
internal static partial class IntrinsicMethods
{
	[IntrinsicMethod("Mosa.Platform.x64.Intrinsic::CpuIdRAX")]
	private static void CpuIdRAX(Context context, MethodCompiler methodCompiler)
	{
		var result = context.Result;
		var operand1 = context.Operand1;
		var operand2 = context.Operand2;

		var rax = Operand.CreateCPURegister(methodCompiler.TypeSystem.BuiltIn.I8, CPURegister.RAX);
		var rbx = Operand.CreateCPURegister(methodCompiler.TypeSystem.BuiltIn.I8, CPURegister.RBX);
		var rcx = Operand.CreateCPURegister(methodCompiler.TypeSystem.BuiltIn.I8, CPURegister.RCX);
		var rdx = Operand.CreateCPURegister(methodCompiler.TypeSystem.BuiltIn.I8, CPURegister.RDX);

		context.SetInstruction(X64.Mov64, rax, operand1);
		context.AppendInstruction(X64.Mov64, rcx, operand2);
		context.AppendInstruction(X64.CpuId, rax, rax, rcx);
		context.AppendInstruction(IRInstruction.Gen, rax, rbx, rcx, rdx);
		context.AppendInstruction(X64.Mov64, result, rax);
	}
}
