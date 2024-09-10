```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,330.5 ns** |    **101.10 ns** |     **5.54 ns** |     **1,324.6 ns** |     **1,335.6 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,468.8 ns |    102.64 ns |     5.63 ns |     1,464.9 ns |     1,475.3 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,717.8 ns |     79.47 ns |     4.36 ns |     1,712.8 ns |     1,720.9 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,672.3 ns |    201.55 ns |    11.05 ns |     2,662.4 ns |     2,684.2 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       205.4 ns |     12.89 ns |     0.71 ns |       204.6 ns |       206.0 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       298.2 ns |     31.07 ns |     1.70 ns |       296.4 ns |       299.7 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       488.4 ns |     20.67 ns |     1.13 ns |       487.7 ns |       489.7 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,799.7 ns** |  **1,089.65 ns** |    **59.73 ns** | **1,545,741.2 ns** | **1,545,860.6 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,370.5 ns |  2,382.40 ns |   130.59 ns |   614,221.3 ns |   614,463.9 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   655,175.8 ns |  3,418.88 ns |   187.40 ns |   654,983.7 ns |   655,358.1 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,373,408.4 ns | 40,445.70 ns | 2,216.97 ns | 1,372,111.2 ns | 1,375,968.3 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,407.5 ns |  7,119.11 ns |   390.22 ns |   162,164.9 ns |   162,857.7 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,639.7 ns |  3,659.79 ns |   200.61 ns |    91,423.2 ns |    91,819.2 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,347.7 ns |    941.15 ns |    51.59 ns |    65,290.9 ns |    65,391.5 ns |      - |      40 B |
