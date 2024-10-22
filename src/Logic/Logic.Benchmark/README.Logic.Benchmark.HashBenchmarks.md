```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,320.9 ns** |     **42.69 ns** |     **2.34 ns** |     **1,318.6 ns** |     **1,323.3 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,471.4 ns |     57.68 ns |     3.16 ns |     1,467.9 ns |     1,474.2 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,692.8 ns |     80.44 ns |     4.41 ns |     1,687.9 ns |     1,696.5 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,694.1 ns |    188.78 ns |    10.35 ns |     2,686.2 ns |     2,705.8 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       198.8 ns |     10.98 ns |     0.60 ns |       198.1 ns |       199.2 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       312.5 ns |     34.93 ns |     1.91 ns |       311.2 ns |       314.7 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       471.7 ns |     28.74 ns |     1.58 ns |       470.7 ns |       473.5 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,539,995.3 ns** | **88,029.13 ns** | **4,825.17 ns** | **1,537,200.5 ns** | **1,545,566.9 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,038.7 ns |  5,801.10 ns |   317.98 ns |   613,677.7 ns |   614,277.0 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   654,842.9 ns | 28,610.05 ns | 1,568.21 ns |   653,172.2 ns |   656,283.0 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,370,560.9 ns | 63,180.67 ns | 3,463.15 ns | 1,367,064.6 ns | 1,373,989.9 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,289.4 ns |  2,188.26 ns |   119.95 ns |   162,180.9 ns |   162,418.2 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,417.6 ns |    449.87 ns |    24.66 ns |    91,391.4 ns |    91,440.3 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,567.3 ns |  8,417.85 ns |   461.41 ns |    65,245.6 ns |    66,095.9 ns |      - |      40 B |
