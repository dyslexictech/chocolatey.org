﻿// Copyright 2011 - Present RealDimensions Software, LLC, the original 
// authors/contributors from ChocolateyGallery
// at https://github.com/chocolatey/chocolatey.org,
// and the authors/contributors of NuGetGallery 
// at https://github.com/NuGet/NuGetGallery
//  
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using MarkdownSharp;

namespace NuGetGallery
{
    public class ListPackageVersionViewModel
    {
        public ListPackageVersionViewModel(DisplayPackageViewModel package, DisplayPackageViewModel currentPackageVersion, bool moderationRole, Markdown markdownGenerator, bool displayVersion)
        {
            Package = package;
            CurrentPackageVersion = currentPackageVersion;
            ModerationRole = moderationRole;
            MarkdownGenerator = markdownGenerator;
            DisplayVersion = displayVersion;
        }

        public DisplayPackageViewModel Package { get; set; }
        public DisplayPackageViewModel CurrentPackageVersion { get; set; }
        public bool ModerationRole { get; set; }
        public Markdown MarkdownGenerator { get; set; }
        public bool DisplayVersion { get; set; }
    }
}
