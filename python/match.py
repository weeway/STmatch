import shell
import maxflow


def main():
    config = shell.get_config()

    s = config['stu']
    t = config['tea']

    max_flow = maxflow.MaxFlow(s, t)
    max_flow.main()


main()
