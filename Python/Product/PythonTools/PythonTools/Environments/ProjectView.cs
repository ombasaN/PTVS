// Python Tools for Visual Studio
// Copyright(c) Microsoft Corporation
// All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the License); you may not use
// this file except in compliance with the License. You may obtain a copy of the
// License at http://www.apache.org/licenses/LICENSE-2.0
//
// THIS CODE IS PROVIDED ON AN  *AS IS* BASIS, WITHOUT WARRANTIES OR CONDITIONS
// OF ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING WITHOUT LIMITATION ANY
// IMPLIED WARRANTIES OR CONDITIONS OF TITLE, FITNESS FOR A PARTICULAR PURPOSE,
// MERCHANTABLITY OR NON-INFRINGEMENT.
//
// See the Apache Version 2.0 License for specific language governing
// permissions and limitations under the License.

using System;
using System.Linq;
using Microsoft.PythonTools.Project;

namespace Microsoft.PythonTools.Environments {
    sealed class ProjectView {
        public PythonProjectNode Node { get; }
        public string Name { get; set; }
        public string HomeFolder { get; set; }
        public string[] InterpreterIds { get; set; }
        public string ActiveInterpreterId { get; set; }
        public string RequirementsTxtPath { get; set; }
        public string EnvironmentYmlPath { get; set; }
        public string MissingCondaEnvName { get; set; }

        public ProjectView(PythonProjectNode node) {
            Node = node ?? throw new ArgumentNullException(nameof(node));
            Name = node.Name;
            HomeFolder = node.ProjectHome;
            InterpreterIds = node.InterpreterIds.ToArray();
            ActiveInterpreterId = node.ActiveInterpreter.Configuration.Id;
            RequirementsTxtPath = node.GetRequirementsTxtPath();
            EnvironmentYmlPath = node.GetEnvironmentYmlPath();
        }
    }
}
