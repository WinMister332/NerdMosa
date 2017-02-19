// Copyright (c) MOSA Project. Licensed under the New BSD License.

namespace Mosa.Compiler.Framework
{
	/// <summary>
	/// This abstract class provides support to emit calling convention
	/// specific code.
	/// </summary>
	public abstract class BaseCallingConvention
	{
		#region Methods

		/// <summary>
		/// Expands method call instruction represented by the context to perform the method call.
		/// </summary>
		/// <param name="compiler">The compiler.</param>
		/// <param name="context">The context.</param>
		public abstract void MakeCall(BaseMethodCompiler compiler, Context context);

		/// <summary>
		/// Requests the calling convention to create an appropriate move instruction to populate the return
		/// value of a method.
		/// </summary>
		/// <param name="compiler">The compiler.</param>
		/// <param name="context">The context.</param>
		/// <param name="operand">The operand, that's holding the return value.</param>
		public abstract void SetReturnValue(BaseMethodCompiler compiler, Context context, Operand operand);

		/// <summary>
		/// Retrieves the offset of the first local variable from the stack frame start.
		/// </summary>
		public abstract int OffsetOfFirstLocal { get; }

		/// <summary>
		/// Retrieves the offset of the first parameter From the stack frame start.
		/// </summary>
		public abstract int OffsetOfFirstParameter { get; }

		#endregion Methods
	}
}
