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
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,300.5 ns** |     **49.66 ns** |     **2.72 ns** |     **1,298.4 ns** |     **1,303.6 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,463.6 ns |     13.09 ns |     0.72 ns |     1,462.8 ns |     1,464.3 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,719.1 ns |    173.01 ns |     9.48 ns |     1,708.8 ns |     1,727.5 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,660.1 ns |    177.30 ns |     9.72 ns |     2,654.0 ns |     2,671.3 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       199.1 ns |     12.65 ns |     0.69 ns |       198.3 ns |       199.6 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       282.7 ns |      7.00 ns |     0.38 ns |       282.3 ns |       283.0 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       503.2 ns |     14.92 ns |     0.82 ns |       502.3 ns |       504.0 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,614.9 ns** |  **4,068.22 ns** |   **222.99 ns** | **1,545,386.5 ns** | **1,545,832.1 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,140.3 ns |  1,367.42 ns |    74.95 ns |   614,074.8 ns |   614,222.1 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   655,051.9 ns |  1,979.15 ns |   108.48 ns |   654,966.6 ns |   655,174.0 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,374,728.3 ns | 47,822.55 ns | 2,621.32 ns | 1,372,344.7 ns | 1,377,535.7 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,387.1 ns |  5,960.88 ns |   326.74 ns |   162,190.4 ns |   162,764.2 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,355.1 ns |    245.86 ns |    13.48 ns |    91,342.5 ns |    91,369.3 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,276.6 ns |  4,771.78 ns |   261.56 ns |    64,974.7 ns |    65,437.0 ns |      - |      40 B |
