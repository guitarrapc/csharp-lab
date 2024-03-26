```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error         | StdDev       | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|--------------:|-------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,321.4 ns** |     **159.29 ns** |      **8.73 ns** |     **1,312.0 ns** |     **1,329.3 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,457.0 ns |      13.27 ns |      0.73 ns |     1,456.5 ns |     1,457.8 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,722.2 ns |      54.38 ns |      2.98 ns |     1,718.9 ns |     1,724.8 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,680.6 ns |     686.73 ns |     37.64 ns |     2,652.7 ns |     2,723.4 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       204.5 ns |      24.16 ns |      1.32 ns |       203.0 ns |       205.3 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       294.0 ns |      39.86 ns |      2.18 ns |       292.1 ns |       296.4 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       498.0 ns |      46.08 ns |      2.53 ns |       495.9 ns |       500.8 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,710.3 ns** |   **9,074.08 ns** |    **497.38 ns** | **1,545,289.6 ns** | **1,546,259.3 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,240.2 ns |   2,630.31 ns |    144.18 ns |   614,074.6 ns |   614,337.8 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   656,071.9 ns |  19,669.43 ns |  1,078.15 ns |   654,865.5 ns |   656,941.3 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,385,221.8 ns | 404,302.97 ns | 22,161.21 ns | 1,372,378.7 ns | 1,410,811.3 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   163,374.1 ns |  37,664.89 ns |  2,064.54 ns |   162,161.5 ns |   165,757.9 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,396.9 ns |     423.42 ns |     23.21 ns |    91,372.1 ns |    91,418.1 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,177.4 ns |   5,546.83 ns |    304.04 ns |    64,941.4 ns |    65,520.5 ns |      - |      40 B |
