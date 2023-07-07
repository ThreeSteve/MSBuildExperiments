# MSBuildExperiments
Various experiments  with things like Nugetizer, GitInfo, Simplified output path. ...

Dependent Projects Using ProjectReference Include and Alias

- Three "Fundamental" projects **A**, **B** and **C** (new)
- Two "Lib" Projects **APlusB and APlusBPlusC**
- One "App" Project **APlusBPlusC_And_APlusB**

and then Console Apps

- **Console A B C** No Clashes
- **Console_All_Six_Libraries** Name Chashes - does not build
- **Console_All_Six_Libraries_Alias** Uses Aliases to allow all six libraries to be called

<img width="989" alt="image" src="https://github.com/ThreeSteve/MSBuildExperiments/assets/99689011/76a86d57-ed6a-4860-877b-654f8c74fe27">

