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
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,328.6 ns** |     **59.50 ns** |     **3.26 ns** |     **1,324.9 ns** |     **1,330.9 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,480.6 ns |    172.44 ns |     9.45 ns |     1,470.8 ns |     1,489.7 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,695.8 ns |     85.63 ns |     4.69 ns |     1,690.5 ns |     1,699.6 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,683.7 ns |    236.20 ns |    12.95 ns |     2,671.5 ns |     2,697.3 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       203.3 ns |      4.26 ns |     0.23 ns |       203.1 ns |       203.5 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       287.1 ns |     12.81 ns |     0.70 ns |       286.4 ns |       287.7 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       499.2 ns |     23.50 ns |     1.29 ns |       498.0 ns |       500.6 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,723.7 ns** |  **4,777.39 ns** |   **261.86 ns** | **1,545,459.6 ns** | **1,545,983.3 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,780.1 ns | 19,861.40 ns | 1,088.67 ns |   614,144.8 ns |   616,037.2 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   656,033.7 ns | 15,698.59 ns |   860.49 ns |   655,140.1 ns |   656,856.8 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,372,333.5 ns |  5,789.92 ns |   317.36 ns | 1,371,968.0 ns | 1,372,539.6 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,585.1 ns | 12,416.54 ns |   680.59 ns |   162,185.6 ns |   163,371.0 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,438.8 ns |  2,394.19 ns |   131.23 ns |    91,356.2 ns |    91,590.1 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,892.4 ns | 10,938.21 ns |   599.56 ns |    65,269.4 ns |    66,465.4 ns |      - |      40 B |
