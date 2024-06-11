```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.301
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error         | StdDev       | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|--------------:|-------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,312.4 ns** |      **29.92 ns** |      **1.64 ns** |     **1,310.6 ns** |     **1,313.8 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,454.0 ns |      87.99 ns |      4.82 ns |     1,448.6 ns |     1,457.7 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,695.4 ns |      35.47 ns |      1.94 ns |     1,693.2 ns |     1,697.0 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,679.6 ns |      48.59 ns |      2.66 ns |     2,676.7 ns |     2,682.0 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       203.1 ns |       7.31 ns |      0.40 ns |       202.8 ns |       203.6 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       284.8 ns |      43.35 ns |      2.38 ns |       282.5 ns |       287.3 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       493.8 ns |      17.22 ns |      0.94 ns |       493.1 ns |       494.9 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,589.4 ns** |   **1,512.63 ns** |     **82.91 ns** | **1,545,530.2 ns** | **1,545,684.2 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,135.9 ns |   1,174.65 ns |     64.39 ns |   614,095.6 ns |   614,210.1 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   655,445.0 ns |  14,343.79 ns |    786.23 ns |   654,908.6 ns |   656,347.5 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,386,169.8 ns | 404,501.61 ns | 22,172.10 ns | 1,373,154.5 ns | 1,411,770.7 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,268.5 ns |     849.52 ns |     46.57 ns |   162,235.3 ns |   162,321.8 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,356.0 ns |     182.83 ns |     10.02 ns |    91,345.4 ns |    91,365.3 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,137.2 ns |   6,780.57 ns |    371.67 ns |    64,898.3 ns |    65,565.4 ns |      - |      40 B |
