```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev    | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|----------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,318.8 ns** |     **17.14 ns** |   **0.94 ns** |     **1,317.7 ns** |     **1,319.4 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,474.0 ns |     30.10 ns |   1.65 ns |     1,472.1 ns |     1,475.3 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,694.9 ns |    117.86 ns |   6.46 ns |     1,687.9 ns |     1,700.6 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,663.9 ns |    304.10 ns |  16.67 ns |     2,650.1 ns |     2,682.4 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       200.9 ns |     11.86 ns |   0.65 ns |       200.1 ns |       201.4 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       285.8 ns |     28.63 ns |   1.57 ns |       284.9 ns |       287.6 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       484.4 ns |     16.32 ns |   0.89 ns |       483.5 ns |       485.3 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,300.4 ns** |    **292.62 ns** |  **16.04 ns** | **1,545,284.3 ns** | **1,545,316.4 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   613,955.3 ns |  1,080.32 ns |  59.22 ns |   613,916.9 ns |   614,023.5 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   654,736.2 ns |    794.32 ns |  43.54 ns |   654,689.9 ns |   654,776.3 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,373,509.0 ns | 14,756.03 ns | 808.83 ns | 1,372,595.4 ns | 1,374,133.6 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,548.3 ns |  3,158.09 ns | 173.11 ns |   162,445.6 ns |   162,748.1 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,388.5 ns |    395.09 ns |  21.66 ns |    91,367.7 ns |    91,410.9 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,490.7 ns |  3,626.55 ns | 198.78 ns |    65,276.3 ns |    65,669.0 ns |      - |      40 B |
