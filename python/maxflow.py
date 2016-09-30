import data
from queue import Queue

for_safe = 5


class Edge(object):
    def __init__(self, u, v, cap):
        self.v = v
        self.u = u
        self.cap = cap

    def __repr__(self):
        return "(u({})->v({}),cap->{})" \
            .format(self.u,
                    self.v,
                    self.cap)


class MaxFlow(object):
    def __init__(self, n, m):
        self.s = 0
        self.t = n + m + 1
        self.n = n
        self.m = m
        self.cnt = 0
        self.es = []
        self.tabs = [[] for i in range(n + m + 2)]
        self.dis = [0xffffffff for i in range(n + m + 2)]
        self.stus = data.gen_stus(n, m)
        self.teas = data.gen_teas(m)

    def bfs(self):
        q = Queue(-1)
        q.put(self.s)
        self.dis = [0xffffffff for i in range \
            (self.n + self.m + 2)]
        self.dis[self.s] = 0
        while not q.empty():
            front = q.get()
            for index in self.tabs[front]:
                e = self.es[index]
                if e.cap > 0 and \
                                self.dis[e.v] == 0xffffffff:
                    self.dis[e.v] = self.dis[front] + 1
                    q.put(e.v)
        return self.dis[self.t] < 0xffffffff

    def add_edge(self, u, v, cap):
        self.tabs[u].append(len(self.es))
        self.es.append(Edge(u, v, cap))
        self.tabs[v].append(len(self.es))
        self.es.append(Edge(v, u, 0))

    def dinic(self, x, maxflow):
        if x == self.t:
            return maxflow
        for index in self.tabs[x]:
            e = self.es[index]
            if self.dis[e.v] == self.dis[x] + 1 \
                    and e.cap > 0:
                flow = self.dinic(e.v, min(maxflow, e.cap))
                if flow:
                    e.cap -= flow
                    self.es[index ^ 1].cap += flow
                    return flow
        return 0

    def excute(self):
        ans = 0
        while self.bfs():
            flow = self.dinic(self.s, 0xffffffff)
            ans += flow
        return ans

    def main(self):
        for stu in self.stus:
            self.add_edge(self.s, stu.i, 1)
            for index in stu.list:
                self.add_edge(stu.i, self.n + index, 1)
        k = 0
        for tea in self.teas:
            k += tea.n
            self.add_edge(self.n + tea.i, self.t, tea.n)

        print('导师数{} 学生数{} 可收学生数{}'.format(self.m, self.n, k))
        print('已匹配{}个学生:'.format(self.excute()))
        for e in self.es:
            if e.cap == 0 and \
                            e.u in range(1, self.n + 1) \
                    and e.v in range(self.n + 1, self.n + self.m + 1):
                print("{}->{}".format(self.stus[e.u - 1].name, \
                                      self.teas[e.v - (self.n + 1)].name))


        print('未匹配学生:')

