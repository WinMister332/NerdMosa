﻿// Copyright (c) MOSA Project. Licensed under the New BSD License.

using Mosa.Compiler.Framework;
using Mosa.Platform.x64.CompilerStages;

namespace Mosa.Platform.x64.Intrinsic;

/// <summary>
/// IntrinsicMethods
/// </summary>
internal static partial class IntrinsicMethods
{
	[IntrinsicMethod("Mosa.Platform.x64.Intrinsic::GetMultibootRBX")]
	private static void GetMultibootRBX(Context context, MethodCompiler methodCompiler)
	{
		var MultibootEBX = Operand.CreateUnmanagedSymbolPointer(MultibootV1Stage.MultibootEBX, methodCompiler.TypeSystem);

		context.SetInstruction(IRInstruction.Load64, context.Result, MultibootEBX, methodCompiler.Constant32_0);
	}
}
