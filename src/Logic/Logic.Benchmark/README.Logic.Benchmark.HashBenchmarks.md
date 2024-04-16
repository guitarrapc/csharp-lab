```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,342.7 ns** |     **75.93 ns** |     **4.16 ns** |     **1,339.3 ns** |     **1,347.4 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,469.2 ns |     71.52 ns |     3.92 ns |     1,464.7 ns |     1,471.9 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,714.4 ns |     28.37 ns |     1.55 ns |     1,713.0 ns |     1,716.1 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,689.6 ns |    774.21 ns |    42.44 ns |     2,663.3 ns |     2,738.5 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       200.5 ns |      6.86 ns |     0.38 ns |       200.1 ns |       200.8 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       285.6 ns |     20.26 ns |     1.11 ns |       284.6 ns |       286.8 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       500.7 ns |     25.41 ns |     1.39 ns |       499.2 ns |       502.0 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,647.1 ns** |  **1,633.21 ns** |    **89.52 ns** | **1,545,549.1 ns** | **1,545,724.5 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,601.2 ns |  5,843.78 ns |   320.32 ns |   614,292.7 ns |   614,932.1 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   655,755.0 ns | 26,712.37 ns | 1,464.19 ns |   654,818.6 ns |   657,442.3 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,373,411.6 ns | 11,259.42 ns |   617.17 ns | 1,372,699.0 ns | 1,373,774.7 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,266.4 ns |    623.50 ns |    34.18 ns |   162,226.9 ns |   162,286.9 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,952.6 ns | 17,712.52 ns |   970.88 ns |    91,379.7 ns |    93,073.6 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,031.2 ns |  2,030.62 ns |   111.31 ns |    64,948.6 ns |    65,157.8 ns |      - |      40 B |
