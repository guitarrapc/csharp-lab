```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,311.7 ns** |     **75.96 ns** |     **4.16 ns** |     **1,308.0 ns** |     **1,316.2 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,450.6 ns |     83.75 ns |     4.59 ns |     1,447.1 ns |     1,455.8 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,720.5 ns |     49.05 ns |     2.69 ns |     1,717.8 ns |     1,723.2 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,668.2 ns |    322.67 ns |    17.69 ns |     2,653.4 ns |     2,687.8 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       201.9 ns |     19.80 ns |     1.09 ns |       200.7 ns |       202.7 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       286.2 ns |     28.05 ns |     1.54 ns |       284.7 ns |       287.7 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       501.2 ns |     34.68 ns |     1.90 ns |       499.6 ns |       503.3 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,508.2 ns** |  **4,908.65 ns** |   **269.06 ns** | **1,545,237.8 ns** | **1,545,775.9 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,333.4 ns |    571.74 ns |    31.34 ns |   614,299.3 ns |   614,360.9 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   656,288.0 ns | 21,229.79 ns | 1,163.68 ns |   655,131.3 ns |   657,458.6 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,374,981.6 ns | 78,052.41 ns | 4,278.32 ns | 1,372,211.3 ns | 1,379,909.1 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,918.5 ns | 19,908.30 ns | 1,091.24 ns |   162,166.5 ns |   164,170.1 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,789.4 ns |  5,929.37 ns |   325.01 ns |    91,422.7 ns |    92,041.7 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    64,935.2 ns |  1,386.82 ns |    76.02 ns |    64,886.5 ns |    65,022.8 ns |      - |      40 B |
