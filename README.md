# AssemblyInfo Update

## set-version

This Github action updates _AssemblyInfo.cs_ files in .NET projects with the specified version number, suffixed with [`github.run_number`](https://docs.github.com/en/actions/learn-github-actions/contexts).

The version number is expected to be in [SemVer format](https://semver.org/) with at least the major and minor version numbers, e.g. `1.20`, `2.17.4`, `1.4.9-alpha`.  Any pre-release/metadata suffix will be discarded and [`github.run_number`](https://docs.github.com/en/actions/learn-github-actions/contexts) appended to produce a 3- or 4-element version number.

Note that any existing value in the file is overwritten, so may be left at, say, "0.0.0.0".  The updated file is not committed back to the repository.

This action is useful for automatically updating the assembly info version of a project prior to building it, for example, where the version number should be set to the latest tag.

### Input arguments

* `version` (required): The assembly version in semver format
* `directory`: the directory where the assembly info file is located (or the top-most directory to search if `recursive` is `true`).  Defaults to '.\\'
* `filename`: the file name of the assembly info file.  Defaults to 'AssemblyInfo.cs'
* `recursive`: if `true`, updates all assembly info files matching the `filename` argument, in all subdirectories.  Defaults to `true`

### Output arguments

* `version`: the value of the version used in the assembly info

### Example Usage

#### Minimal example

```yml
- name: Set version in all AssemblyInfo.cs files
  uses: secondbounce/assemblyinfo-update@v2
  with:
    version: '1.0.8'
```

#### Complete example

```yml
- name: Set version in .\Properties\SharedAssemblyInfo.cs
  id: set-assembly-version
  uses: secondbounce/assemblyinfo-update@v2
  with:
    version: '2.1.16-alpha'
    directory: '.\Properties'
    filename: 'SharedAssemblyInfo.cs'
    recursive: false

- name: Display the version used
  run: echo "{{steps.set-assembly-version.outputs.version}}"
```

## Development Testing

This repo includes a test workflow - _.github/workflows/test-actions.yml_ - that is configured to run on each commit to the `develop` (and `main`) branch.  This workflow runs the latest code as a test, saving the updated sample files as artifacts, should the output need to be checked.
