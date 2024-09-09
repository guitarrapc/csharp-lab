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
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,318.6 ns** |    **105.02 ns** |     **5.76 ns** |     **1,313.6 ns** |     **1,324.9 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,465.7 ns |    100.37 ns |     5.50 ns |     1,459.7 ns |     1,470.4 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,694.6 ns |    170.73 ns |     9.36 ns |     1,688.6 ns |     1,705.4 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,671.9 ns |    166.07 ns |     9.10 ns |     2,662.5 ns |     2,680.6 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       200.7 ns |     15.74 ns |     0.86 ns |       199.7 ns |       201.4 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       288.4 ns |     29.00 ns |     1.59 ns |       286.6 ns |       289.8 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       476.1 ns |     28.57 ns |     1.57 ns |       474.8 ns |       477.8 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,426.2 ns** |  **7,000.89 ns** |   **383.74 ns** | **1,545,200.7 ns** | **1,545,869.3 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,773.7 ns | 22,236.16 ns | 1,218.84 ns |   614,043.6 ns |   616,180.8 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   654,735.1 ns |    601.85 ns |    32.99 ns |   654,700.0 ns |   654,765.5 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,372,628.4 ns |  3,680.38 ns |   201.73 ns | 1,372,465.8 ns | 1,372,854.2 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,567.2 ns |  7,384.24 ns |   404.76 ns |   162,234.8 ns |   163,018.0 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,713.2 ns |  3,956.85 ns |   216.89 ns |    91,514.2 ns |    91,944.4 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,613.2 ns |  4,556.34 ns |   249.75 ns |    65,330.7 ns |    65,804.7 ns |      - |      40 B |
