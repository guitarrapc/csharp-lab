```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error         | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|--------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,237.4 ns** |      **91.97 ns** |     **5.04 ns** |     **1,232.5 ns** |     **1,242.6 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,370.2 ns |     100.93 ns |     5.53 ns |     1,366.3 ns |     1,376.5 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,624.2 ns |      44.66 ns |     2.45 ns |     1,622.1 ns |     1,626.9 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,573.6 ns |     160.13 ns |     8.78 ns |     2,565.2 ns |     2,582.7 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       210.2 ns |      11.85 ns |     0.65 ns |       209.7 ns |       211.0 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       287.3 ns |      14.26 ns |     0.78 ns |       286.6 ns |       288.1 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       477.2 ns |      27.46 ns |     1.51 ns |       475.6 ns |       478.6 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,555,882.0 ns** |  **52,546.84 ns** | **2,880.27 ns** | **1,554,194.9 ns** | **1,559,207.7 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   620,737.8 ns | 101,449.22 ns | 5,560.77 ns |   617,476.7 ns |   627,158.6 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   658,733.3 ns |   4,030.52 ns |   220.93 ns |   658,588.2 ns |   658,987.5 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,383,911.7 ns | 107,292.76 ns | 5,881.08 ns | 1,380,477.7 ns | 1,390,702.4 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   163,397.9 ns |   8,181.59 ns |   448.46 ns |   163,125.3 ns |   163,915.5 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,928.8 ns |   1,598.06 ns |    87.60 ns |    91,865.2 ns |    92,028.8 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,798.1 ns |   6,023.71 ns |   330.18 ns |    65,602.8 ns |    66,179.3 ns |      - |      40 B |
