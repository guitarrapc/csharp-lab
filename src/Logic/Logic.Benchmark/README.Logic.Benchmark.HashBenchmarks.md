```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,318.8 ns** |     **13.84 ns** |     **0.76 ns** |     **1,318.0 ns** |     **1,319.6 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,464.7 ns |    120.95 ns |     6.63 ns |     1,460.1 ns |     1,472.3 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,692.0 ns |     39.51 ns |     2.17 ns |     1,690.3 ns |     1,694.4 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,666.5 ns |    343.76 ns |    18.84 ns |     2,648.5 ns |     2,686.1 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       215.1 ns |      9.24 ns |     0.51 ns |       214.7 ns |       215.7 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       287.9 ns |     15.24 ns |     0.84 ns |       287.0 ns |       288.4 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       495.7 ns |     44.91 ns |     2.46 ns |       493.8 ns |       498.4 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,461.3 ns** |  **3,300.18 ns** |   **180.89 ns** | **1,545,335.9 ns** | **1,545,668.7 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,359.2 ns |  3,274.11 ns |   179.46 ns |   614,218.2 ns |   614,561.2 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   655,258.8 ns |  7,388.17 ns |   404.97 ns |   654,961.0 ns |   655,720.0 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,376,552.6 ns | 46,785.48 ns | 2,564.47 ns | 1,374,175.7 ns | 1,379,270.5 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,456.2 ns |  4,861.76 ns |   266.49 ns |   162,249.5 ns |   162,757.0 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,498.5 ns |  3,437.01 ns |   188.39 ns |    91,341.5 ns |    91,707.4 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,694.1 ns |  3,922.81 ns |   215.02 ns |    65,514.9 ns |    65,932.5 ns |      - |      40 B |
