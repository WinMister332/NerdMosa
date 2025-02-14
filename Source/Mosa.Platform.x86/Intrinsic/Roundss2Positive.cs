﻿// Copyright (c) MOSA Project. Licensed under the New BSD License.

using Mosa.Compiler.Framework;

namespace Mosa.Platform.x86.Intrinsic;

/// <summary>
/// IntrinsicMethods
/// </summary>
internal static partial class IntrinsicMethods
{
	[IntrinsicMethod("Mosa.Platform.x86.Intrinsic::Roundss2Positive")]
	private static void Roundss2Positive(Context context, MethodCompiler methodCompiler)
	{
		context.SetInstruction(X86.Roundss, context.Result, context.Operand1, methodCompiler.CreateConstant((byte)2));
	}
}
