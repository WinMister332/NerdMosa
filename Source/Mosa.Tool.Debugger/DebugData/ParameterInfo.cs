﻿// Copyright (c) MOSA Project. Licensed under the New BSD License.

namespace Mosa.Tool.Debugger.DebugData;

public class ParameterInfo
{
	public int MethodID { get; set; }
	public uint Index { get; set; }
	public uint Offset { get; set; }
	public int ParameterTypeID { get; set; }
	public string Name { get; set; }
	public string FullName { get; set; }
	public uint Attributes { get; set; }
	public uint Size { get; set; }
}
