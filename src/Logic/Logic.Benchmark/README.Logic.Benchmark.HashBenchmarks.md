```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev    | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|----------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,322.1 ns** |    **138.35 ns** |   **7.58 ns** |     **1,315.9 ns** |     **1,330.5 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,440.8 ns |     47.68 ns |   2.61 ns |     1,437.8 ns |     1,442.5 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,674.8 ns |    133.20 ns |   7.30 ns |     1,667.8 ns |     1,682.4 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,614.6 ns |     12.27 ns |   0.67 ns |     2,613.8 ns |     2,615.1 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       190.9 ns |     12.34 ns |   0.68 ns |       190.2 ns |       191.5 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       273.9 ns |     38.09 ns |   2.09 ns |       272.1 ns |       276.2 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       479.6 ns |     49.83 ns |   2.73 ns |       477.2 ns |       482.6 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,546,364.8 ns** |  **7,641.02 ns** | **418.83 ns** | **1,545,884.6 ns** | **1,546,654.2 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,471.5 ns |  7,851.23 ns | 430.35 ns |   614,089.9 ns |   614,938.0 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   655,914.6 ns | 16,040.26 ns | 879.22 ns |   655,159.1 ns |   656,879.7 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,373,763.8 ns | 17,479.47 ns | 958.11 ns | 1,372,935.2 ns | 1,374,812.9 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,599.0 ns |  6,555.15 ns | 359.31 ns |   162,197.2 ns |   162,889.6 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,534.8 ns |  3,694.50 ns | 202.51 ns |    91,415.3 ns |    91,768.6 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    32,701.6 ns |  1,529.94 ns |  83.86 ns |    32,651.7 ns |    32,798.4 ns |      - |      40 B |
