```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.202
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method          | Runtime  | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |--------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **.NET 8.0** | **KLVJ(...)0t2z [160]** |     **1,239.7 ns** |     **20.54 ns** |     **1.13 ns** |     **1,238.4 ns** |     **1,240.5 ns** | **0.0668** |    **1128 B** |
| SHA1String      | .NET 8.0 | KLVJ(...)0t2z [160] |     1,428.3 ns |      8.95 ns |     0.49 ns |     1,427.7 ns |     1,428.5 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 8.0 | KLVJ(...)0t2z [160] |     1,651.9 ns |    320.41 ns |    17.56 ns |     1,638.3 ns |     1,671.7 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 8.0 | KLVJ(...)0t2z [160] |     2,616.6 ns |     20.42 ns |     1.12 ns |     2,615.3 ns |     2,617.5 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 8.0 | KLVJ(...)0t2z [160] |       190.8 ns |     15.11 ns |     0.83 ns |       189.9 ns |       191.4 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 8.0 | KLVJ(...)0t2z [160] |       267.8 ns |     35.98 ns |     1.97 ns |       266.0 ns |       269.9 ns | 0.0434 |     728 B |
| XxHash128String | .NET 8.0 | KLVJ(...)0t2z [160] |       460.8 ns |     81.73 ns |     4.48 ns |       457.9 ns |       466.0 ns | 0.0672 |    1128 B |
| MD5String       | .NET 9.0 | KLVJ(...)0t2z [160] |     1,224.4 ns |    127.99 ns |     7.02 ns |     1,217.1 ns |     1,231.1 ns | 0.0668 |    1128 B |
| SHA1String      | .NET 9.0 | KLVJ(...)0t2z [160] |     1,398.9 ns |    164.82 ns |     9.03 ns |     1,393.1 ns |     1,409.3 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 9.0 | KLVJ(...)0t2z [160] |     1,636.9 ns |    384.28 ns |    21.06 ns |     1,616.7 ns |     1,658.7 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 9.0 | KLVJ(...)0t2z [160] |     2,603.4 ns |    241.05 ns |    13.21 ns |     2,588.1 ns |     2,611.7 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 9.0 | KLVJ(...)0t2z [160] |       177.6 ns |     28.51 ns |     1.56 ns |       175.8 ns |       178.6 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 9.0 | KLVJ(...)0t2z [160] |       255.9 ns |     16.54 ns |     0.91 ns |       255.2 ns |       256.9 ns | 0.0434 |     728 B |
| XxHash128String | .NET 9.0 | KLVJ(...)0t2z [160] |       476.1 ns |     70.08 ns |     3.84 ns |       473.8 ns |       480.5 ns | 0.0668 |    1128 B |
| **MD5Binary**       | **.NET 8.0** | **Byte[1048576]**       | **1,553,831.2 ns** |  **8,746.87 ns** |   **479.45 ns** | **1,553,308.1 ns** | **1,554,249.6 ns** |      **-** |      **41 B** |
| SHA1Binary      | .NET 8.0 | Byte[1048576]       |   617,517.8 ns |  3,749.14 ns |   205.50 ns |   617,347.4 ns |   617,746.0 ns |      - |      49 B |
| SHA256Binary    | .NET 8.0 | Byte[1048576]       |   660,163.0 ns | 30,059.47 ns | 1,647.66 ns |   658,273.6 ns |   661,301.6 ns |      - |      57 B |
| SHA512Binary    | .NET 8.0 | Byte[1048576]       | 1,382,172.1 ns | 40,073.56 ns | 2,196.57 ns | 1,380,578.8 ns | 1,384,677.8 ns |      - |      89 B |
| XxHash32Binary  | .NET 8.0 | Byte[1048576]       |   163,203.2 ns |  5,270.20 ns |   288.88 ns |   163,003.0 ns |   163,534.4 ns |      - |      32 B |
| XxHash64Binary  | .NET 8.0 | Byte[1048576]       |    92,346.0 ns |  7,742.71 ns |   424.40 ns |    91,982.5 ns |    92,812.4 ns |      - |      32 B |
| XxHash128Binary | .NET 8.0 | Byte[1048576]       |    65,800.1 ns |  6,227.55 ns |   341.35 ns |    65,497.4 ns |    66,170.1 ns |      - |      40 B |
| MD5Binary       | .NET 9.0 | Byte[1048576]       | 1,553,340.7 ns |  2,599.41 ns |   142.48 ns | 1,553,179.1 ns | 1,553,448.1 ns |      - |      41 B |
| SHA1Binary      | .NET 9.0 | Byte[1048576]       |   617,269.6 ns |  1,383.07 ns |    75.81 ns |   617,190.4 ns |   617,341.4 ns |      - |      49 B |
| SHA256Binary    | .NET 9.0 | Byte[1048576]       |   659,547.4 ns | 22,424.83 ns | 1,229.18 ns |   658,438.1 ns |   660,868.9 ns |      - |      57 B |
| SHA512Binary    | .NET 9.0 | Byte[1048576]       | 1,384,285.8 ns | 72,986.30 ns | 4,000.63 ns | 1,380,361.4 ns | 1,388,358.6 ns |      - |      89 B |
| XxHash32Binary  | .NET 9.0 | Byte[1048576]       |   163,165.1 ns |  3,263.93 ns |   178.91 ns |   163,059.0 ns |   163,371.6 ns |      - |      32 B |
| XxHash64Binary  | .NET 9.0 | Byte[1048576]       |    91,959.9 ns |  4,394.13 ns |   240.86 ns |    91,816.9 ns |    92,238.0 ns |      - |      32 B |
| XxHash128Binary | .NET 9.0 | Byte[1048576]       |    33,904.4 ns |  5,568.46 ns |   305.23 ns |    33,694.3 ns |    34,254.6 ns |      - |      40 B |
