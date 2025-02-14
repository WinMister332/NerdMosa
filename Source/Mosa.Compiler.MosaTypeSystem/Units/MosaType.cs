﻿// Copyright (c) MOSA Project. Licensed under the New BSD License.

using System;
using System.Collections.Generic;
using System.Text;
using Mosa.Compiler.Common;

namespace Mosa.Compiler.MosaTypeSystem;

public class MosaType : MosaUnit, IEquatable<MosaType>
{
	public MosaModule? Module { get; private set; }

	public string Namespace { get; private set; }

	public string? Signature { get; internal set; }

	public MosaType? BaseType { get; private set; }

	public MosaType? DeclaringType { get; private set; }

	public bool IsInterface { get; private set; }

	public bool IsEnum { get; private set; }

	public bool IsDelegate { get; private set; }

	public bool IsModule { get; private set; }

	public bool IsExplicitLayout { get; private set; }

	public int? ClassSize { get; private set; }

	public int? PackingSize { get; private set; }

	private List<MosaMethod> methods;
	private List<MosaField> fields;
	private List<MosaProperty> properties;
	private List<MosaType> interfaces;

	public IList<MosaMethod> Methods { get; private set; }

	public IList<MosaProperty> Properties { get; private set; }

	public IList<MosaField> Fields { get; private set; }

	public IList<MosaType> Interfaces { get; private set; }

	public MosaTypeAttributes TypeAttributes { get; private set; }

	public MosaTypeCode TypeCode { get; private set; }

	public bool IsU1 => TypeCode == MosaTypeCode.U1;

	public bool IsI1 => TypeCode == MosaTypeCode.I1;

	public bool IsU2 => TypeCode == MosaTypeCode.U2;

	public bool IsI2 => TypeCode == MosaTypeCode.I2;

	public bool IsU4 => TypeCode == MosaTypeCode.U4;

	public bool IsI4 => TypeCode == MosaTypeCode.I4;

	public bool IsU8 => TypeCode == MosaTypeCode.U8;

	public bool IsI8 => TypeCode == MosaTypeCode.I8;

	public bool IsR4 => TypeCode == MosaTypeCode.R4;

	public bool IsR8 => TypeCode == MosaTypeCode.R8;

	public bool IsI => TypeCode == MosaTypeCode.I;

	public bool IsU => TypeCode == MosaTypeCode.U;

	public bool IsBoolean => TypeCode == MosaTypeCode.Boolean;

	public bool IsChar => TypeCode == MosaTypeCode.Char;

	public bool IsVoid => TypeCode == MosaTypeCode.Void;

	public bool IsManagedPointer => TypeCode == MosaTypeCode.ManagedPointer;

	public bool IsUnmanagedPointer => TypeCode == MosaTypeCode.UnmanagedPointer;

	public bool IsFunctionPointer => TypeCode == MosaTypeCode.FunctionPointer;

	public bool IsTypedRef => TypeCode == MosaTypeCode.TypedRef;

	public bool IsArray => TypeCode is MosaTypeCode.Array or MosaTypeCode.SZArray;

	public bool IsMVar => TypeCode == MosaTypeCode.MVar;

	public bool IsVar => TypeCode == MosaTypeCode.Var;

	public bool HasOpenGenericParams { get; private set; }

	private GenericArgumentsCollection genericArguments;

	public IReadOnlyList<MosaType> GenericArguments { get; private set; }

	public bool IsUI1 => IsU1 || IsI1;

	public bool IsUI2 => IsU2 || IsI2;

	public bool IsUI4 => IsU4 || IsI4;

	public bool IsUI8 => IsU8 || IsI8;

	public bool IsR => IsR4 || IsR8;

	public bool IsN => IsU || IsI;

	public bool IsInteger => IsI1 || IsI2 || IsI4 || IsI8 || IsI || IsU1 || IsU2 || IsU4 || IsU8 || IsU;

	public bool IsPointer => IsManagedPointer || IsUnmanagedPointer || IsFunctionPointer;

	public bool IsReferenceType => TypeCode is MosaTypeCode.ReferenceType or MosaTypeCode.String or MosaTypeCode.Object or MosaTypeCode.Array or MosaTypeCode.SZArray;

	public bool IsValueType =>
		TypeCode is MosaTypeCode.ValueType or MosaTypeCode.Boolean or MosaTypeCode.Char
		|| IsInteger
		|| IsR;

	public bool IsUserValueType =>
		TypeCode == MosaTypeCode.ValueType
		&& !IsEnum
		&& !IsInteger
		&& !IsR
		&& TypeCode != MosaTypeCode.Boolean
		&& TypeCode != MosaTypeCode.Char;

	public MosaType? ElementType { get; private set; }

	public int? GenericParamIndex { get; private set; }

	public MosaType? Modifier { get; private set; }

	public MosaArrayInfo? ArrayInfo { get; private set; }

	public MosaMethodSignature? FunctionPtrSig { get; private set; }

	internal MosaType()
	{
		Namespace = "";

		Methods = (methods = new List<MosaMethod>()).AsReadOnly();
		Fields = (fields = new List<MosaField>()).AsReadOnly();
		Properties = (properties = new List<MosaProperty>()).AsReadOnly();
		Interfaces = (interfaces = new List<MosaType>()).AsReadOnly();

		GenericArguments = genericArguments = new GenericArgumentsCollection();
	}

	internal override MosaType Clone()
	{
		var result = (MosaType)base.Clone();

		result.Methods = (result.methods = new List<MosaMethod>(methods)).AsReadOnly();
		result.Fields = (result.fields = new List<MosaField>(fields)).AsReadOnly();
		result.Properties = (result.properties = new List<MosaProperty>(properties)).AsReadOnly();
		result.Interfaces = (result.interfaces = new List<MosaType>(interfaces)).AsReadOnly();

		result.GenericArguments = result.genericArguments = new GenericArgumentsCollection(genericArguments);

		return result;
	}

	public bool Equals(MosaType? other)
	{
		return SignatureComparer.Equals(this, other);
	}

	public MosaMethod? FindMethodByName(string name)
	{
		foreach (var method in Methods)
		{
			if (method.Name == name)
				return method;
		}

		return null;
	}

	public MosaMethod? FindMethodByNameAndParameters(string name, IList<MosaParameter> parameters)
	{
		foreach (var method in Methods)
		{
			if (method.Name == name && method.Signature?.Parameters.SequenceEquals(parameters) == true)
				return method;
		}

		return null;
	}

	public MosaMethod? FindMethodBySignature(string name, MosaMethodSignature sig)
	{
		foreach (var method in Methods)
		{
			if (method.Name == name && method.Signature?.Equals(sig) == true)
				return method;
		}

		return null;
	}

	public class Mutator : MutatorBase
	{
		private readonly MosaType type;

		internal Mutator(MosaType type)
			: base(type)
		{
			this.type = type;
		}

		public MosaModule? Module { set => type.Module = value; }

		public string Namespace { set => type.Namespace = value; }

		public MosaType? BaseType { set => type.BaseType = value; }

		public MosaType? DeclaringType { set => type.DeclaringType = value; }

		public bool IsInterface { set => type.IsInterface = value; }

		public bool IsEnum { set => type.IsEnum = value; }

		public bool IsDelegate { set => type.IsDelegate = value; }

		public bool IsModule { set => type.IsModule = value; }

		public bool IsExplicitLayout { set => type.IsExplicitLayout = value; }

		public int? ClassSize { set => type.ClassSize = value; }

		public int? PackingSize { set => type.PackingSize = value; }

		public IList<MosaMethod> Methods => type.methods;

		public IList<MosaField> Fields => type.fields;

		public IList<MosaProperty> Properties => type.properties;

		public IList<MosaType> Interfaces => type.interfaces;

		public MosaTypeAttributes TypeAttributes { set => type.TypeAttributes = value; }

		public MosaTypeCode TypeCode { set => type.TypeCode = value; }

		public bool HasOpenGenericParams { set => type.HasOpenGenericParams = value; }

		public GenericArgumentsCollection GenericArguments => type.genericArguments;

		public MosaType? ElementType { set => type.ElementType = value; }

		public int? GenericParamIndex { set => type.GenericParamIndex = value; }

		public MosaType? Modifier { set => type.Modifier = value; }

		public MosaArrayInfo ArrayInfo { set => type.ArrayInfo = value; }

		public MosaMethodSignature FunctionPtrSig { set => type.FunctionPtrSig = value; }

		public override void Dispose()
		{
			SignatureName.UpdateType(type);
			var fName = new StringBuilder();
			var sName = new StringBuilder();

			if (type.DeclaringType != null && type.DeclaringType != type.ElementType)
			{
				if (!string.IsNullOrEmpty(type.Namespace))
				{
					fName.Append(type.Namespace);
					fName.Append(".");
				}

				fName.Append(type.DeclaringType.ShortName);
				fName.Append("+");
				sName.Append(type.DeclaringType.ShortName);
				sName.Append("+");

				fName.Append(type.Name);
				fName.Append(type.Signature);
				sName.Append(type.Name);
				sName.Append(type.Signature);

				type.FullName = fName.ToString();
				type.ShortName = sName.ToString();
			}
			else if (type.DeclaringType != null)
			{
				fName.Append(type.ElementType?.FullName);
				fName.Append(type.Signature);
				sName.Append(type.ElementType?.ShortName);
				sName.Append(type.Signature);

				type.FullName = fName.ToString();
				type.ShortName = sName.ToString();
			}
			else
			{
				if (!string.IsNullOrEmpty(type.Namespace))
				{
					fName.Append(type.Namespace);
					fName.Append(".");
				}

				fName.Append(type.Name);
				fName.Append(type.Signature);
				sName.Append(type.Name);
				sName.Append(type.Signature);

				type.FullName = fName.ToString();
				type.ShortName = sName.ToString();
			}
		}
	}
}
