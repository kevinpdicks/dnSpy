﻿/*
    Copyright (C) 2014-2017 de4dot@gmail.com

    This file is part of dnSpy

    dnSpy is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    dnSpy is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with dnSpy.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Collections.Generic;

namespace dnSpy.Debugger.DotNet.Metadata.Impl.COMD {
	sealed class DmdComMetadataReader : DmdMetadataReaderBase {
		public override Guid ModuleVersionId => throw new NotImplementedException();//TODO:
		public override int MDStreamVersion => throw new NotImplementedException();//TODO:
		public override string ModuleScopeName => throw new NotImplementedException();//TODO:
		public override string ImageRuntimeVersion => throw new NotImplementedException();//TODO:
		public override DmdMethodInfo EntryPoint => throw new NotImplementedException();//TODO:

		readonly object comMetadata;
		readonly DmdDispatcher dispatcher;
		readonly DmdModuleImpl module;

		public DmdComMetadataReader(DmdModuleImpl module, object comMetadata, DmdDispatcher dispatcher) {
			this.module = module ?? throw new ArgumentNullException(nameof(module));
			this.comMetadata = comMetadata ?? throw new ArgumentNullException(nameof(comMetadata));
			this.dispatcher = dispatcher ?? throw new ArgumentNullException(nameof(dispatcher));
		}

		public override DmdType[] GetTypes() => throw new NotImplementedException();//TODO:
		public override DmdType[] GetExportedTypes() => throw new NotImplementedException();//TODO:
		protected override DmdTypeRef ResolveTypeRef(uint rid) => throw new NotImplementedException();//TODO:
		protected override DmdTypeDef ResolveTypeDef(uint rid) => throw new NotImplementedException();//TODO:
		protected override DmdFieldDef ResolveFieldDef(uint rid) => throw new NotImplementedException();//TODO:
		protected override DmdMethodBase ResolveMethodDef(uint rid) => throw new NotImplementedException();//TODO:
		protected override DmdMemberInfo ResolveMemberRef(uint rid, IList<DmdType> genericTypeArguments) => throw new NotImplementedException();//TODO:
		protected override DmdEventDef ResolveEventDef(uint rid) => throw new NotImplementedException();//TODO:
		protected override DmdPropertyInfo ResolvePropertyDef(uint rid) => throw new NotImplementedException();//TODO:
		protected override DmdType ResolveTypeSpec(uint rid, IList<DmdType> genericTypeArguments) => throw new NotImplementedException();//TODO:
		protected override DmdTypeRef ResolveExportedType(uint rid) => throw new NotImplementedException();//TODO:
		protected override DmdMethodBase ResolveMethodSpec(uint rid, IList<DmdType> genericTypeArguments, IList<DmdType> genericMethodArguments) => throw new NotImplementedException();//TODO:
		protected override byte[] ResolveFieldSignature(uint rid) => throw new NotImplementedException();//TODO:
		protected override byte[] ResolveMethodSignature(uint rid) => throw new NotImplementedException();//TODO:
		protected override byte[] ResolveMemberRefSignature(uint rid) => throw new NotImplementedException();//TODO:
		protected override byte[] ResolveStandAloneSigSignature(uint rid) => throw new NotImplementedException();//TODO:
		protected override byte[] ResolveTypeSpecSignature(uint rid) => throw new NotImplementedException();//TODO:
		protected override byte[] ResolveMethodSpecSignature(uint rid) => throw new NotImplementedException();//TODO:
		protected override string ResolveStringCore(uint offset) => throw new NotImplementedException();//TODO:
		public override void GetPEKind(out DmdPortableExecutableKinds peKind, out DmdImageFileMachine machine) => throw new NotImplementedException();//TODO:
		public override DmdAssemblyName GetName() => throw new NotImplementedException();//TODO:
		public override DmdAssemblyName[] GetReferencedAssemblies() => throw new NotImplementedException();//TODO:
		protected override DmdCustomAttributeData[] ReadAssemblyCustomAttributes(uint rid) => throw new NotImplementedException();//TODO:
		protected override DmdCustomAttributeData[] ReadModuleCustomAttributes(uint rid) => throw new NotImplementedException();//TODO:
		protected override DmdCustomAttributeData[] ReadTypeDefCustomAttributes(uint rid) => throw new NotImplementedException();//TODO:
		protected override DmdCustomAttributeData[] ReadFieldCustomAttributes(uint rid) => throw new NotImplementedException();//TODO:
		protected override DmdCustomAttributeData[] ReadMethodCustomAttributes(uint rid) => throw new NotImplementedException();//TODO:
		protected override DmdCustomAttributeData[] ReadParamCustomAttributes(uint rid) => throw new NotImplementedException();//TODO:
		protected override DmdCustomAttributeData[] ReadEventCustomAttributes(uint rid) => throw new NotImplementedException();//TODO:
		protected override DmdCustomAttributeData[] ReadPropertyCustomAttributes(uint rid) => throw new NotImplementedException();//TODO:
	}
}