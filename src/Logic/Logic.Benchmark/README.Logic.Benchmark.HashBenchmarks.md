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
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,320.6 ns** |     **11.68 ns** |     **0.64 ns** |     **1,320.0 ns** |     **1,321.3 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,469.0 ns |     34.72 ns |     1.90 ns |     1,466.8 ns |     1,470.3 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,694.2 ns |     24.47 ns |     1.34 ns |     1,693.0 ns |     1,695.7 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,647.4 ns |    281.11 ns |    15.41 ns |     2,633.4 ns |     2,663.9 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       199.5 ns |     25.04 ns |     1.37 ns |       198.5 ns |       201.1 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       332.5 ns |      7.43 ns |     0.41 ns |       332.1 ns |       332.9 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       477.2 ns |      4.47 ns |     0.24 ns |       477.0 ns |       477.5 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,512.8 ns** |  **3,308.36 ns** |   **181.34 ns** | **1,545,329.9 ns** | **1,545,692.5 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,723.1 ns | 18,148.98 ns |   994.81 ns |   614,124.3 ns |   615,871.5 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   655,834.6 ns | 22,781.85 ns | 1,248.75 ns |   654,955.1 ns |   657,263.9 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,377,681.5 ns | 96,970.08 ns | 5,315.26 ns | 1,372,719.7 ns | 1,383,290.8 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,188.5 ns |  1,566.42 ns |    85.86 ns |   162,092.2 ns |   162,256.9 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,732.8 ns |  7,179.63 ns |   393.54 ns |    91,447.6 ns |    92,181.8 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,651.8 ns |  6,070.46 ns |   332.74 ns |    65,312.9 ns |    65,978.0 ns |      - |      40 B |
