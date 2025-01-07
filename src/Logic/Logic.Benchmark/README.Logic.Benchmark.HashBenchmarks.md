```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error         | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|--------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,229.2 ns** |     **376.05 ns** |    **20.61 ns** |     **1,217.0 ns** |     **1,253.0 ns** | **0.0668** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,407.0 ns |      95.82 ns |     5.25 ns |     1,401.3 ns |     1,411.6 ns | 0.0839 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,644.6 ns |     211.03 ns |    11.57 ns |     1,632.2 ns |     1,655.1 ns | 0.1106 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,562.9 ns |     486.52 ns |    26.67 ns |     2,547.3 ns |     2,593.7 ns | 0.1907 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       179.7 ns |      40.05 ns |     2.20 ns |       177.6 ns |       182.0 ns | 0.0348 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       260.2 ns |      74.88 ns |     4.10 ns |       255.9 ns |       264.0 ns | 0.0434 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       487.9 ns |      73.95 ns |     4.05 ns |       485.3 ns |       492.5 ns | 0.0672 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,554,754.4 ns** |  **20,819.14 ns** | **1,141.17 ns** | **1,553,772.5 ns** | **1,556,006.4 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   623,104.7 ns | 168,191.33 ns | 9,219.13 ns |   617,662.5 ns |   633,749.1 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   659,080.7 ns |  20,654.38 ns | 1,132.14 ns |   658,331.6 ns |   660,383.1 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,381,618.3 ns |  23,053.76 ns | 1,263.65 ns | 1,380,373.7 ns | 1,382,900.2 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   163,646.3 ns |   3,554.41 ns |   194.83 ns |   163,517.7 ns |   163,870.5 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    92,195.0 ns |   7,105.23 ns |   389.46 ns |    91,901.6 ns |    92,636.9 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    33,462.4 ns |   2,350.61 ns |   128.84 ns |    33,348.4 ns |    33,602.2 ns |      - |      40 B |
