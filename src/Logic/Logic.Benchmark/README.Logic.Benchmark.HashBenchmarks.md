```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error         | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|--------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,315.6 ns** |      **15.14 ns** |     **0.83 ns** |     **1,315.1 ns** |     **1,316.6 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,446.1 ns |     130.41 ns |     7.15 ns |     1,441.5 ns |     1,454.4 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,682.3 ns |     137.64 ns |     7.54 ns |     1,677.0 ns |     1,690.9 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,666.8 ns |      21.71 ns |     1.19 ns |     2,665.9 ns |     2,668.2 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       198.5 ns |      16.46 ns |     0.90 ns |       197.5 ns |       199.1 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       324.1 ns |      14.61 ns |     0.80 ns |       323.6 ns |       325.0 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       496.0 ns |      18.48 ns |     1.01 ns |       495.1 ns |       497.1 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,516.3 ns** |   **8,823.12 ns** |   **483.62 ns** | **1,545,091.1 ns** | **1,546,042.4 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,480.6 ns |   3,422.12 ns |   187.58 ns |   614,363.2 ns |   614,697.0 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   655,202.7 ns |   2,286.34 ns |   125.32 ns |   655,058.7 ns |   655,287.5 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,375,682.1 ns | 116,825.60 ns | 6,403.61 ns | 1,371,911.8 ns | 1,383,075.9 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,882.1 ns |   8,763.80 ns |   480.37 ns |   162,450.5 ns |   163,399.6 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,471.9 ns |   3,614.58 ns |   198.13 ns |    91,334.2 ns |    91,699.0 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,607.8 ns |   3,461.73 ns |   189.75 ns |    65,396.7 ns |    65,764.1 ns |      - |      40 B |
