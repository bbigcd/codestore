# 测试GeoJson功能

## 检测一个经纬度点是否在区域内
https://stackoverflow.com/questions/43892459/check-if-geo-point-is-inside-or-outside-of-polygon

## 数据来源
http://datav.aliyun.com/tools/atlas/#&lat=33.54139466898275&lng=104.3701171875&zoom=4
http://geojson.io/#map=6/28.140/108.171

## 参照算法
http://turfjs.org/docs/#pointOnFeature

> 如果多边形是凸的，则可以将多边形视为从第一个顶点开始的“路径”。如果一个点始终位于构成路径的所有线段的同一侧，则该点位于该多边形的内部。给定P0（x0，y0）和P1（x1，y1）之间的线段，另一个点P（x，y）与该线段具有以下关系。计算（y-y0）（x1-x0）-（x-x0）（y1-y0）如果小于0，则P位于线段的右侧；如果大于0，则P位于线段的左侧；如果等于0，则其位于线段上。