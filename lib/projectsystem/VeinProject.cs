namespace vein.project
{
    using System;
    using System.Xml.Serialization;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Xml;
    using extensions;
    using NuGet.Versioning;
    using Sprache;

    [DebuggerDisplay("{Name}.vproj")]
    public class VeinProject
    {
        internal readonly YAML.Project _project;

        internal VeinProject(FileInfo file, YAML.Project project)
        {
            _project = project;
            Name = Path.GetFileNameWithoutExtension(file.FullName);
            WorkDir = file.Directory;
            Dependencies = new(this);
        }

        public string Name { get; }
        public DirectoryInfo WorkDir { get; }
        public DirectoryInfo CacheDir => new DirectoryInfo(Path.Combine(WorkDir.FullName, "obj"));

        public bool Packable => _project.Packable ?? false;
        public List<PackageAuthor> Authors => _project.Authors;
        public string Description => _project.Description;
        public string License => _project.License;
        public PackageUrls Urls => _project.Urls;

        public NuGetVersion Version => new NuGetVersion(_project.Version);

        public string Runtime
        {
            get => _project.Runtime;
            internal set => _project.Runtime = value;
        }

        public IReadOnlyCollection<FileInfo> Sources => WorkDir
            .EnumerateFiles("*.vein", SearchOption.AllDirectories)
            .Where(x => !x.Name.EndsWith(".temp.vein"))
            .Where(x => !x.Name.EndsWith(".generated.vein"))
            .ToList()
            .AsReadOnly();

        private IEnumerable<IProjectRef> refs =>
            _project.Packages?.Select(PackageReference.Convert)
            ?? new List<PackageReference>();

        public Dep Dependencies { get; }

        public class Dep
        {
            private readonly VeinProject _project;

            internal Dep(VeinProject p) => _project = p;

            public IReadOnlyCollection<ProjectReference> Projects => _project
                .refs
                .OfExactType<ProjectReference>()
                .ToList()
                .AsReadOnly();

            public IReadOnlyCollection<PackageReference> Packages => _project
                .refs
                .OfExactType<PackageReference>()
                .ToList()
                .AsReadOnly();
        }


        public VeinSDK SDK => VeinSDK.Resolve(_project.Sdk);


        public static VeinProject LoadFrom(FileInfo info)
        {
            var p = YAML.Project.Load(info);
            return new VeinProject(info, p);
        }
    }
}
